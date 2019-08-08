using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("96e5e1ca-f4f9-447d-860a-58c36c5588cc")]
        public void Method_0013_ac34()
        {
            ii(0x13_ac34, 4); enterw(0x24, 0);                          /* enter 0x24, 0x0 */
            ii(0x13_ac38, 1); pushw(di);                                /* push di */
            ii(0x13_ac39, 1); pushw(si);                                /* push si */
            ii(0x13_ac3a, 1); pushw(ds);                                /* push ds */
            ii(0x13_ac3b, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_ac3e, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_ac40, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x13_ac43, 4); mov(ax, memw_a16[es, bx + 0x8]);          /* mov ax, [es:bx+0x8] */
            ii(0x13_ac47, 4); mov(cx, memw_a16[es, bx + 0x4]);          /* mov cx, [es:bx+0x4] */
            ii(0x13_ac4b, 2); mov(dx, ax);                              /* mov dx, ax */
            ii(0x13_ac4d, 3); mov(memw_a16[ss, bp - 0x20], cx);         /* mov [bp-0x20], cx */
            ii(0x13_ac50, 3); mov(memw_a16[ss, bp - 0x1e], dx);         /* mov [bp-0x1e], dx */
            ii(0x13_ac53, 4); mov(ax, memw_a16[es, bx + 0x14]);         /* mov ax, [es:bx+0x14] */
            ii(0x13_ac57, 2); sub(si, si);                              /* sub si, si */
            ii(0x13_ac59, 4); add(si, memw_a16[es, bx + 0x1c]);         /* add si, [es:bx+0x1c] */
            ii(0x13_ac5d, 3); adc(ax, 0);                               /* adc ax, 0x0 */
            ii(0x13_ac60, 3); mov(memw_a16[ss, bp - 0x8], si);          /* mov [bp-0x8], si */
            ii(0x13_ac63, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x13_ac66, 3); mov(memw_a16[ss, bp - 0x24], si);         /* mov [bp-0x24], si */
            ii(0x13_ac69, 3); mov(memw_a16[ss, bp - 0x22], ax);         /* mov [bp-0x22], ax */
            ii(0x13_ac6c, 4); and(si, 0xf000);                          /* and si, 0xf000 */
            ii(0x13_ac70, 3); mov(bx, memw_a16[ss, bp - 0x24]);         /* mov bx, [bp-0x24] */
            ii(0x13_ac73, 2); mov(di, ax);                              /* mov di, ax */
            ii(0x13_ac75, 2); sub(bx, si);                              /* sub bx, si */
            ii(0x13_ac77, 2); sbb(di, ax);                              /* sbb di, ax */
            ii(0x13_ac79, 2); add(cx, bx);                              /* add cx, bx */
            ii(0x13_ac7b, 2); adc(dx, di);                              /* adc dx, di */
            ii(0x13_ac7d, 3); mov(memw_a16[ss, bp - 0x1a], cx);         /* mov [bp-0x1a], cx */
            ii(0x13_ac80, 3); mov(memw_a16[ss, bp - 0x18], dx);         /* mov [bp-0x18], dx */
            ii(0x13_ac83, 2); mov(ax, cx);                              /* mov ax, cx */
            ii(0x13_ac85, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x13_ac87, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x13_ac89, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x13_ac8b, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x13_ac8d, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_ac8f, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_ac91, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_ac93, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_ac95, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_ac97, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_ac99, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_ac9b, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_ac9d, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x13_aca0, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x13_aca3, 4); test(cx, 0xfff);                          /* test cx, 0xfff */
            ii(0x13_aca7, 2); if(jzw(0x13_acb5, 0xc)) goto l_0x13_acb5; /* jz 0xacb5 */
            ii(0x13_aca9, 3); add(ax, 0x1);                             /* add ax, 0x1 */
            ii(0x13_acac, 3); adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x13_acaf, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x13_acb2, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
        l_0x13_acb5:
            ii(0x13_acb5, 3); pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0x13_acb8, 3); pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0x13_acbb, 1); pushw(dx);                                /* push dx */
            ii(0x13_acbc, 1); pushw(ax);                                /* push ax */
            ii(0x13_acbd, 1); pushw(ds);                                /* push ds */
            ii(0x13_acbe, 3); pushw(0x136b);                            /* push 0x136b */
            ii(0x13_acc1, 1); nop();                                    /* nop */
            ii(0x13_acc2, 1); pushw(cs);                                /* push cs */
            ii(0x13_acc3, 3); callw(0x14_104f, 0x6389);                 /* call 0x104f */
            ii(0x13_acc6, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x13_acc9, 3); mov(ax, memw_a16[ds, 0x1fb0]);            /* mov ax, [0x1fb0] */
            ii(0x13_accc, 4); mov(dx, memw_a16[ds, 0x1fb2]);            /* mov dx, [0x1fb2] */
            ii(0x13_acd0, 3); sub(ax, memw_a16[ss, bp - 0x4]);          /* sub ax, [bp-0x4] */
            ii(0x13_acd3, 3); sbb(dx, memw_a16[ss, bp - 0x2]);          /* sbb dx, [bp-0x2] */
            ii(0x13_acd6, 2); or(dx, dx);                               /* or dx, dx */
            ii(0x13_acd8, 2); if(jgew(0x13_acf4, 0x1a)) goto l_0x13_acf4; /* jge 0xacf4 */
            ii(0x13_acda, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x13_acdd, 6); mov(memw_a16[es, bx + 0x20], 0x8013);     /* mov word [es:bx+0x20], 0x8013 */
            ii(0x13_ace3, 6); mov(memw_a16[es, bx + 0x22], 0);          /* mov word [es:bx+0x22], 0x0 */
            ii(0x13_ace9, 5); or(memb_a16[es, bx + 0x2c], 0x1);         /* or byte [es:bx+0x2c], 0x1 */
            ii(0x13_acee, 1); popw(ds);                                 /* pop ds */
            ii(0x13_acef, 1); popw(si);                                 /* pop si */
            ii(0x13_acf0, 1); popw(di);                                 /* pop di */
            ii(0x13_acf1, 1); leavew();                                 /* leave */
            ii(0x13_acf2, 1); retfw(); return;                          /* retf */
        //  ii(0x13_acf3, 1); Недостижимый код.
        l_0x13_acf4:
            ii(0x13_acf4, 5); cmp(memw_a16[ss, bp - 0x6], 0x1000);      /* cmp word [bp-0x6], 0x1000 */
            ii(0x13_acf9, 2); if(jbw(0x13_ad17, 0x1c)) goto l_0x13_ad17; /* jb 0xad17 */
            ii(0x13_acfb, 2); if(jaw(0x13_acfd, 0)) goto l_0x13_acfd;   /* ja 0xacfd */
        l_0x13_acfd:
            ii(0x13_acfd, 3); mov(ax, memw_a16[ss, bp - 0x8]);          /* mov ax, [bp-0x8] */
            ii(0x13_ad00, 3); mov(dx, memw_a16[ss, bp - 0x6]);          /* mov dx, [bp-0x6] */
            ii(0x13_ad03, 3); add(ax, memw_a16[ss, bp - 0x20]);         /* add ax, [bp-0x20] */
            ii(0x13_ad06, 3); adc(dx, memw_a16[ss, bp - 0x1e]);         /* adc dx, [bp-0x1e] */
            ii(0x13_ad09, 4); cmp(dx, memw_a16[ds, 0x4fda]);            /* cmp dx, [0x4fda] */
            ii(0x13_ad0d, 2); if(jbw(0x13_ad1c, 0xd)) goto l_0x13_ad1c; /* jb 0xad1c */
            ii(0x13_ad0f, 2); if(jaw(0x13_ad17, 0x6)) goto l_0x13_ad17; /* ja 0xad17 */
            ii(0x13_ad11, 4); cmp(ax, memw_a16[ds, 0x4fd8]);            /* cmp ax, [0x4fd8] */
            ii(0x13_ad15, 2); if(jbew(0x13_ad1c, 0x5)) goto l_0x13_ad1c; /* jbe 0xad1c */
        l_0x13_ad17:
            ii(0x13_ad17, 1); popw(ds);                                 /* pop ds */
            ii(0x13_ad18, 1); popw(si);                                 /* pop si */
            ii(0x13_ad19, 1); popw(di);                                 /* pop di */
            ii(0x13_ad1a, 1); leavew();                                 /* leave */
            ii(0x13_ad1b, 1); retfw(); return;                          /* retf */
        l_0x13_ad1c:
            ii(0x13_ad1c, 3); mov(ax, memw_a16[ss, bp - 0x8]);          /* mov ax, [bp-0x8] */
            ii(0x13_ad1f, 3); mov(dx, memw_a16[ss, bp - 0x6]);          /* mov dx, [bp-0x6] */
            ii(0x13_ad22, 3); sub(ax, 0);                               /* sub ax, 0x0 */
            ii(0x13_ad25, 4); sbb(dx, 0x1000);                          /* sbb dx, 0x1000 */
            ii(0x13_ad29, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x13_ad2b, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x13_ad2d, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x13_ad2f, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x13_ad31, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_ad33, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_ad35, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_ad37, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_ad39, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_ad3b, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_ad3d, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_ad3f, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_ad41, 3); mov(memw_a16[ss, bp - 0x16], ax);         /* mov [bp-0x16], ax */
            ii(0x13_ad44, 3); mov(memw_a16[ss, bp - 0x14], dx);         /* mov [bp-0x14], dx */
            ii(0x13_ad47, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x13_ad49, 3); mov(memw_a16[ss, bp - 0x18], ax);         /* mov [bp-0x18], ax */
            ii(0x13_ad4c, 3); mov(memw_a16[ss, bp - 0x1a], ax);         /* mov [bp-0x1a], ax */
            ii(0x13_ad4f, 2); jmpw(0x13_ad62, 0x11); goto l_0x13_ad62;  /* jmp 0xad62 */
        //    ii(0x13_ad51, 1); nop();                                    /* nop */
        l_0x13_ad52:
            ii(0x13_ad52, 4); add(memw_a16[ss, bp - 0x1a], 0x1);        /* add word [bp-0x1a], 0x1 */
            ii(0x13_ad56, 4); adc(memw_a16[ss, bp - 0x18], 0);          /* adc word [bp-0x18], 0x0 */
            ii(0x13_ad5a, 4); add(memw_a16[ss, bp - 0x16], 0x1);        /* add word [bp-0x16], 0x1 */
            ii(0x13_ad5e, 4); adc(memw_a16[ss, bp - 0x14], 0);          /* adc word [bp-0x14], 0x0 */
        l_0x13_ad62:
            ii(0x13_ad62, 3); mov(ax, memw_a16[ss, bp - 0x1a]);         /* mov ax, [bp-0x1a] */
            ii(0x13_ad65, 3); mov(dx, memw_a16[ss, bp - 0x18]);         /* mov dx, [bp-0x18] */
            ii(0x13_ad68, 3); cmp(memw_a16[ss, bp - 0x2], dx);          /* cmp [bp-0x2], dx */
            ii(0x13_ad6b, 2); if(jaew(0x13_ad70, 0x3)) goto l_0x13_ad70; /* jae 0xad70 */
            ii(0x13_ad6d, 3); jmpw(0x13_af38, 0x1c8); goto l_0x13_af38; /* jmp 0xaf38 */
        l_0x13_ad70:
            ii(0x13_ad70, 2); if(jaw(0x13_ad7a, 0x8)) goto l_0x13_ad7a; /* ja 0xad7a */
            ii(0x13_ad72, 3); cmp(memw_a16[ss, bp - 0x4], ax);          /* cmp [bp-0x4], ax */
            ii(0x13_ad75, 2); if(jaw(0x13_ad7a, 0x3)) goto l_0x13_ad7a; /* ja 0xad7a */
            ii(0x13_ad77, 3); jmpw(0x13_af38, 0x1be); goto l_0x13_af38; /* jmp 0xaf38 */
        l_0x13_ad7a:
            ii(0x13_ad7a, 3); mov(ax, memw_a16[ss, bp - 0x16]);         /* mov ax, [bp-0x16] */
            ii(0x13_ad7d, 3); mov(dx, memw_a16[ss, bp - 0x14]);         /* mov dx, [bp-0x14] */
            ii(0x13_ad80, 3); add(ax, 0);                               /* add ax, 0x0 */
            ii(0x13_ad83, 3); adc(dx, 0x1);                             /* adc dx, 0x1 */
            ii(0x13_ad86, 3); mov(memw_a16[ss, bp - 0x12], ax);         /* mov [bp-0x12], ax */
            ii(0x13_ad89, 3); mov(memw_a16[ss, bp - 0x10], dx);         /* mov [bp-0x10], dx */
            ii(0x13_ad8c, 3); pushw(memw_a16[ss, bp - 0x14]);           /* push word [bp-0x14] */
            ii(0x13_ad8f, 3); pushw(memw_a16[ss, bp - 0x16]);           /* push word [bp-0x16] */
            ii(0x13_ad92, 4); pushw(memw_a16[ds, 0x4ff6]);              /* push word [0x4ff6] */
            ii(0x13_ad96, 4); pushw(memw_a16[ds, 0x4ff4]);              /* push word [0x4ff4] */
            ii(0x13_ad9a, 3); callw(0x13_90c4, -0x1cd9);                /* call 0x90c4 */
            ii(0x13_ad9d, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_ada0, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x13_ada2, 2); if(jnzw(0x13_ada7, 0x3)) goto l_0x13_ada7; /* jnz 0xada7 */
            ii(0x13_ada4, 3); jmpw(0x13_af26, 0x17f); goto l_0x13_af26; /* jmp 0xaf26 */
        l_0x13_ada7:
            ii(0x13_ada7, 3); pushw(memw_a16[ss, bp - 0x14]);           /* push word [bp-0x14] */
            ii(0x13_adaa, 3); pushw(memw_a16[ss, bp - 0x16]);           /* push word [bp-0x16] */
            ii(0x13_adad, 4); pushw(memw_a16[ds, 0x4f8e]);              /* push word [0x4f8e] */
            ii(0x13_adb1, 4); pushw(memw_a16[ds, 0x4f8c]);              /* push word [0x4f8c] */
            ii(0x13_adb5, 3); callw(0x13_9208, -0x1bb0);                /* call 0x9208 */
            ii(0x13_adb8, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_adbb, 3); mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x13_adbe, 3); mov(memw_a16[ss, bp - 0xa], dx);          /* mov [bp-0xa], dx */
            ii(0x13_adc1, 4); test(memb_a16[ss, bp - 0xc], 0x1);        /* test byte [bp-0xc], 0x1 */
            ii(0x13_adc5, 2); if(jzw(0x13_ade8, 0x21)) goto l_0x13_ade8; /* jz 0xade8 */
            ii(0x13_adc7, 3); pushw(memw_a16[ss, bp - 0x10]);           /* push word [bp-0x10] */
            ii(0x13_adca, 3); pushw(memw_a16[ss, bp - 0x12]);           /* push word [bp-0x12] */
            ii(0x13_adcd, 1); nop();                                    /* nop */
            ii(0x13_adce, 1); pushw(cs);                                /* push cs */
            ii(0x13_adcf, 3); callw(0x13_901a, -0x1db8);                /* call 0x901a */
            ii(0x13_add2, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x13_add5, 3); mov(memw_a16[ss, bp - 0x1c], ax);         /* mov [bp-0x1c], ax */
            ii(0x13_add8, 4); les(bx, ds, 0x4f9c);                      /* les bx, [0x4f9c] */
            ii(0x13_addc, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x13_adde, 4); test(memb_a16[es, bx + si], 0x80);        /* test byte [es:bx+si], 0x80 */
            ii(0x13_ade2, 2); if(jzw(0x13_ade8, 0x4)) goto l_0x13_ade8; /* jz 0xade8 */
            ii(0x13_ade4, 3); jmpw(0x13_af19, 0x132); goto l_0x13_af19; /* jmp 0xaf19 */
        //    ii(0x13_ade7, 1); nop();                                    /* nop */
        l_0x13_ade8:
            ii(0x13_ade8, 1); nop();                                    /* nop */
            ii(0x13_ade9, 1); pushw(cs);                                /* push cs */
            ii(0x13_adea, 3); callw(0x13_790e, -0x34df);                /* call 0x790e */
            ii(0x13_aded, 3); mov(memw_a16[ss, bp - 0x1c], ax);         /* mov [bp-0x1c], ax */
            ii(0x13_adf0, 3); cmp(ax, 0xffff);                          /* cmp ax, 0xffff */
            ii(0x13_adf3, 2); if(jnzw(0x13_ae1a, 0x25)) goto l_0x13_ae1a; /* jnz 0xae1a */
            ii(0x13_adf5, 1); pushw(ds);                                /* push ds */
            ii(0x13_adf6, 3); pushw(0x1383);                            /* push 0x1383 */
            ii(0x13_adf9, 1); nop();                                    /* nop */
            ii(0x13_adfa, 1); pushw(cs);                                /* push cs */
            ii(0x13_adfb, 3); callw(0x14_104f, 0x6251);                 /* call 0x104f */
            ii(0x13_adfe, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x13_ae01, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x13_ae04, 6); mov(memw_a16[es, bx + 0x20], 0x8013);     /* mov word [es:bx+0x20], 0x8013 */
            ii(0x13_ae0a, 6); mov(memw_a16[es, bx + 0x22], 0);          /* mov word [es:bx+0x22], 0x0 */
            ii(0x13_ae10, 5); or(memb_a16[es, bx + 0x2c], 0x1);         /* or byte [es:bx+0x2c], 0x1 */
            ii(0x13_ae15, 1); popw(ds);                                 /* pop ds */
            ii(0x13_ae16, 1); popw(si);                                 /* pop si */
            ii(0x13_ae17, 1); popw(di);                                 /* pop di */
            ii(0x13_ae18, 1); leavew();                                 /* leave */
            ii(0x13_ae19, 1); retfw(); return;                          /* retf */
        l_0x13_ae1a:
            ii(0x13_ae1a, 3); pushw(memw_a16[ss, bp - 0x14]);           /* push word [bp-0x14] */
            ii(0x13_ae1d, 3); pushw(memw_a16[ss, bp - 0x16]);           /* push word [bp-0x16] */
            ii(0x13_ae20, 4); pushw(memw_a16[ds, 0x4f8e]);              /* push word [0x4f8e] */
            ii(0x13_ae24, 4); pushw(memw_a16[ds, 0x4f8c]);              /* push word [0x4f8c] */
            ii(0x13_ae28, 3); callw(0x13_9208, -0x1c23);                /* call 0x9208 */
            ii(0x13_ae2b, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_ae2e, 3); mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x13_ae31, 3); mov(memw_a16[ss, bp - 0xa], dx);          /* mov [bp-0xa], dx */
            ii(0x13_ae34, 4); test(memb_a16[ss, bp - 0xc], 0x1);        /* test byte [bp-0xc], 0x1 */
            ii(0x13_ae38, 2); if(jnzw(0x13_ae64, 0x2a)) goto l_0x13_ae64; /* jnz 0xae64 */
            ii(0x13_ae3a, 2); pushw(0);                                 /* push 0x0 */
            ii(0x13_ae3c, 3); pushw(memw_a16[ss, bp - 0x1c]);           /* push word [bp-0x1c] */
            ii(0x13_ae3f, 3); pushw(memw_a16[ss, bp - 0x10]);           /* push word [bp-0x10] */
            ii(0x13_ae42, 3); pushw(memw_a16[ss, bp - 0x12]);           /* push word [bp-0x12] */
            ii(0x13_ae45, 1); nop();                                    /* nop */
            ii(0x13_ae46, 1); pushw(cs);                                /* push cs */
            ii(0x13_ae47, 3); callw(0x13_7dac, -0x309e);                /* call 0x7dac */
            ii(0x13_ae4a, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_ae4d, 3); pushw(memw_a16[ss, bp - 0xa]);            /* push word [bp-0xa] */
            ii(0x13_ae50, 3); pushw(memw_a16[ss, bp - 0xc]);            /* push word [bp-0xc] */
            ii(0x13_ae53, 3); pushw(memw_a16[ss, bp - 0x10]);           /* push word [bp-0x10] */
            ii(0x13_ae56, 3); pushw(memw_a16[ss, bp - 0x12]);           /* push word [bp-0x12] */
            ii(0x13_ae59, 1); nop();                                    /* nop */
            ii(0x13_ae5a, 1); pushw(cs);                                /* push cs */
            ii(0x13_ae5b, 3); callw(0x13_7cfc, -0x3162);                /* call 0x7cfc */
            ii(0x13_ae5e, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_ae61, 3); jmpw(0x13_af19, 0xb5); goto l_0x13_af19;  /* jmp 0xaf19 */
        l_0x13_ae64:
            ii(0x13_ae64, 3); pushw(memw_a16[ss, bp - 0x10]);           /* push word [bp-0x10] */
            ii(0x13_ae67, 3); pushw(memw_a16[ss, bp - 0x12]);           /* push word [bp-0x12] */
            ii(0x13_ae6a, 1); nop();                                    /* nop */
            ii(0x13_ae6b, 1); pushw(cs);                                /* push cs */
            ii(0x13_ae6c, 3); callw(0x13_901a, -0x1e55);                /* call 0x901a */
            ii(0x13_ae6f, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x13_ae72, 3); mov(memw_a16[ss, bp - 0xe], ax);          /* mov [bp-0xe], ax */
            ii(0x13_ae75, 2); pushw(0);                                 /* push 0x0 */
            ii(0x13_ae77, 1); pushw(ax);                                /* push ax */
            ii(0x13_ae78, 3); mov(ax, memw_a16[ds, 0x4fd8]);            /* mov ax, [0x4fd8] */
            ii(0x13_ae7b, 4); mov(dx, memw_a16[ds, 0x4fda]);            /* mov dx, [0x4fda] */
            ii(0x13_ae7f, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x13_ae81, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x13_ae83, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x13_ae85, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x13_ae87, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_ae89, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_ae8b, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_ae8d, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_ae8f, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_ae91, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_ae93, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_ae95, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_ae97, 1); pushw(dx);                                /* push dx */
            ii(0x13_ae98, 1); pushw(ax);                                /* push ax */
            ii(0x13_ae99, 1); nop();                                    /* nop */
            ii(0x13_ae9a, 1); pushw(cs);                                /* push cs */
            ii(0x13_ae9b, 3); callw(0x13_7dac, -0x30f2);                /* call 0x7dac */
            ii(0x13_ae9e, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_aea1, 2); pushw(0);                                 /* push 0x0 */
            ii(0x13_aea3, 3); pushw(memw_a16[ss, bp - 0x1c]);           /* push word [bp-0x1c] */
            ii(0x13_aea6, 3); pushw(memw_a16[ss, bp - 0x10]);           /* push word [bp-0x10] */
            ii(0x13_aea9, 3); pushw(memw_a16[ss, bp - 0x12]);           /* push word [bp-0x12] */
            ii(0x13_aeac, 1); nop();                                    /* nop */
            ii(0x13_aead, 1); pushw(cs);                                /* push cs */
            ii(0x13_aeae, 3); callw(0x13_7dac, -0x3105);                /* call 0x7dac */
            ii(0x13_aeb1, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_aeb4, 3); mov(ax, memw_a16[ds, 0x4fd8]);            /* mov ax, [0x4fd8] */
            ii(0x13_aeb7, 4); mov(dx, memw_a16[ds, 0x4fda]);            /* mov dx, [0x4fda] */
            ii(0x13_aebb, 3); and(ax, 0xf000);                          /* and ax, 0xf000 */
            ii(0x13_aebe, 1); pushw(dx);                                /* push dx */
            ii(0x13_aebf, 1); pushw(ax);                                /* push ax */
            ii(0x13_aec0, 1); nop();                                    /* nop */
            ii(0x13_aec1, 1); pushw(cs);                                /* push cs */
            ii(0x13_aec2, 3); callw(0x13_8988, -0x253d);                /* call 0x8988 */
            ii(0x13_aec5, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x13_aec8, 3); mov(ax, memw_a16[ss, bp - 0x12]);         /* mov ax, [bp-0x12] */
            ii(0x13_aecb, 3); mov(dx, memw_a16[ss, bp - 0x10]);         /* mov dx, [bp-0x10] */
            ii(0x13_aece, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x13_aed0, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x13_aed2, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x13_aed4, 2); sub(al, al);                              /* sub al, al */
            ii(0x13_aed6, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_aed8, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_aeda, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_aedc, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_aede, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_aee0, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_aee2, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_aee4, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_aee6, 1); pushw(dx);                                /* push dx */
            ii(0x13_aee7, 1); pushw(ax);                                /* push ax */
            ii(0x13_aee8, 4); pushw(memw_a16[ds, 0x1fea]);              /* push word [0x1fea] */
            ii(0x13_aeec, 1); nop();                                    /* nop */
            ii(0x13_aeed, 1); pushw(cs);                                /* push cs */
            ii(0x13_aeee, 3); callw(0x13_89bc, -0x2535);                /* call 0x89bc */
            ii(0x13_aef1, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x13_aef4, 1); pushw(ds);                                /* push ds */
            ii(0x13_aef5, 1); pushw(es);                                /* push es */
            ii(0x13_aef6, 3); mov(cx, 0x400);                           /* mov cx, 0x400 */
            ii(0x13_aef9, 4); les(di, ds, 0x1fe8);                      /* les di, [0x1fe8] */
            ii(0x13_aefd, 4); lds(si, ds, 0x4fb8);                      /* lds si, [0x4fb8] */
            ii(0x13_af01, 3); rep_a16(() => movsd_a16());               /* rep movsd */
            ii(0x13_af04, 1); popw(es);                                 /* pop es */
            ii(0x13_af05, 1); popw(ds);                                 /* pop ds */
            ii(0x13_af06, 3); mov(bx, memw_a16[ss, bp - 0xe]);          /* mov bx, [bp-0xe] */
            ii(0x13_af09, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x13_af0c, 4); les(si, ds, 0x4fa4);                      /* les si, [0x4fa4] */
            ii(0x13_af10, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x13_af12, 4); mov(memw_a16[es, bx + si + 0x2], ax);     /* mov [es:bx+si+0x2], ax */
            ii(0x13_af16, 3); mov(memw_a16[es, bx + si], ax);           /* mov [es:bx+si], ax */
        l_0x13_af19:
            ii(0x13_af19, 3); pushw(memw_a16[ss, bp - 0x1c]);           /* push word [bp-0x1c] */
            ii(0x13_af1c, 1); nop();                                    /* nop */
            ii(0x13_af1d, 1); pushw(cs);                                /* push cs */
            ii(0x13_af1e, 3); callw(0x13_7e98, -0x3089);                /* call 0x7e98 */
            ii(0x13_af21, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x13_af24, 2); jmpw(0x13_af34, 0xe); goto l_0x13_af34;   /* jmp 0xaf34 */
        l_0x13_af26:
            ii(0x13_af26, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x13_af29, 5); and(memb_a16[es, bx + 0x2c], -0x2 /* 0xfe */); /* and byte [es:bx+0x2c], 0xfe */
            ii(0x13_af2e, 1); popw(ds);                                 /* pop ds */
            ii(0x13_af2f, 1); popw(si);                                 /* pop si */
            ii(0x13_af30, 1); popw(di);                                 /* pop di */
            ii(0x13_af31, 1); leavew();                                 /* leave */
            ii(0x13_af32, 1); retfw(); return;                          /* retf */
        //  ii(0x13_af33, 1); Недостижимый код.
        l_0x13_af34:
            ii(0x13_af34, 3); jmpw(0x13_ad52, -0x1e5); goto l_0x13_ad52; /* jmp 0xad52 */
        //    ii(0x13_af37, 1); nop();                                    /* nop */
        l_0x13_af38:
            ii(0x13_af38, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x13_af3b, 5); and(memb_a16[es, bx + 0x2c], -0x2 /* 0xfe */); /* and byte [es:bx+0x2c], 0xfe */
            ii(0x13_af40, 1); popw(ds);                                 /* pop ds */
            ii(0x13_af41, 1); popw(si);                                 /* pop si */
            ii(0x13_af42, 1); popw(di);                                 /* pop di */
            ii(0x13_af43, 1); leavew();                                 /* leave */
            ii(0x13_af44, 1); retfw(); return;                          /* retf */
        }
    }
}
