﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProgramTree;

namespace SimpleLang.Visitors{
    class OptExpr1Visitor : ChangeVisitor {
        public override void VisitBinOpNode(BinOpNode binop){
            switch (binop.Op){
                case OpType.MULT:
                    if (binop.Left is IntNumNode && (binop.Left as IntNumNode).Val == 1){
                        binop.Right.Visit(this);
                        ReplaceExpr(binop, binop.Right);
                    }
                    else if (binop.Right is IntNumNode && (binop.Right as IntNumNode).Val == 1){
                        binop.Left.Visit(this);
                        ReplaceExpr(binop, binop.Left);

                    }
                    else base.VisitBinOpNode(binop);
                    break;

                case OpType.DIV:
                    if (binop.Right is IntNumNode && (binop.Right as IntNumNode).Val == 1){
                        binop.Left.Visit(this);
                        ReplaceExpr(binop, binop.Left);
                    }
                    break;

                default:
                    base.VisitBinOpNode(binop);
                    break;
            }
        }
    }
}