using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_ac34-ce557b8e")]
        public void Method_0017_ac34()
        {
            ii(0x17_ac34, 4); enter(0x24, 0);                           /* enter 0x24, 0x0 */
            ii(0x17_ac38, 1); push(di);                                 /* push di */
            ii(0x17_ac39, 1); push(si);                                 /* push si */
            ii(0x17_ac3a, 1); push(ds);                                 /* push ds */
            ii(0x17_ac3b, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_ac3e, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_ac40, 3); les(bx, memw[ss, bp + 0x6]);              /* les bx, [bp+0x6] */
            ii(0x17_ac43, 4); mov(ax, memw[es, bx + 0x8]);              /* mov ax, [es:bx+0x8] */
            ii(0x17_ac47, 4); mov(cx, memw[es, bx + 0x4]);              /* mov cx, [es:bx+0x4] */
            ii(0x17_ac4b, 2); mov(dx, ax);                              /* mov dx, ax */
            ii(0x17_ac4d, 3); mov(memw[ss, bp - 0x20], cx);             /* mov [bp-0x20], cx */
            ii(0x17_ac50, 3); mov(memw[ss, bp - 0x1e], dx);             /* mov [bp-0x1e], dx */
            ii(0x17_ac53, 4); mov(ax, memw[es, bx + 0x14]);             /* mov ax, [es:bx+0x14] */
            ii(0x17_ac57, 2); sub(si, si);                              /* sub si, si */
            ii(0x17_ac59, 4); add(si, memw[es, bx + 0x1c]);             /* add si, [es:bx+0x1c] */
            ii(0x17_ac5d, 3); adc(ax, 0);                               /* adc ax, 0x0 */
            ii(0x17_ac60, 3); mov(memw[ss, bp - 0x8], si);              /* mov [bp-0x8], si */
            ii(0x17_ac63, 3); mov(memw[ss, bp - 0x6], ax);              /* mov [bp-0x6], ax */
            ii(0x17_ac66, 3); mov(memw[ss, bp - 0x24], si);             /* mov [bp-0x24], si */
            ii(0x17_ac69, 3); mov(memw[ss, bp - 0x22], ax);             /* mov [bp-0x22], ax */
            ii(0x17_ac6c, 4); and(si, 0xf000);                          /* and si, 0xf000 */
            ii(0x17_ac70, 3); mov(bx, memw[ss, bp - 0x24]);             /* mov bx, [bp-0x24] */
            ii(0x17_ac73, 2); mov(di, ax);                              /* mov di, ax */
            ii(0x17_ac75, 2); sub(bx, si);                              /* sub bx, si */
            ii(0x17_ac77, 2); sbb(di, ax);                              /* sbb di, ax */
            ii(0x17_ac79, 2); add(cx, bx);                              /* add cx, bx */
            ii(0x17_ac7b, 2); adc(dx, di);                              /* adc dx, di */
            ii(0x17_ac7d, 3); mov(memw[ss, bp - 0x1a], cx);             /* mov [bp-0x1a], cx */
            ii(0x17_ac80, 3); mov(memw[ss, bp - 0x18], dx);             /* mov [bp-0x18], dx */
            ii(0x17_ac83, 2); mov(ax, cx);                              /* mov ax, cx */
            ii(0x17_ac85, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x17_ac87, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x17_ac89, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x17_ac8b, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x17_ac8d, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_ac8f, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_ac91, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_ac93, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_ac95, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_ac97, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_ac99, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_ac9b, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_ac9d, 3); mov(memw[ss, bp - 0x4], ax);              /* mov [bp-0x4], ax */
            ii(0x17_aca0, 3); mov(memw[ss, bp - 0x2], dx);              /* mov [bp-0x2], dx */
            ii(0x17_aca3, 4); test(cx, 0xfff);                          /* test cx, 0xfff */
            ii(0x17_aca7, 2); if(jz(0x17_acb5, 0xc)) goto l_0x17_acb5;  /* jz 0xacb5 */
            ii(0x17_aca9, 3); add(ax, 0x1);                             /* add ax, 0x1 */
            ii(0x17_acac, 3); adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x17_acaf, 3); mov(memw[ss, bp - 0x4], ax);              /* mov [bp-0x4], ax */
            ii(0x17_acb2, 3); mov(memw[ss, bp - 0x2], dx);              /* mov [bp-0x2], dx */
        l_0x17_acb5:
            ii(0x17_acb5, 3); push(memw[ss, bp - 0x6]);                 /* push word [bp-0x6] */
            ii(0x17_acb8, 3); push(memw[ss, bp - 0x8]);                 /* push word [bp-0x8] */
            ii(0x17_acbb, 1); push(dx);                                 /* push dx */
            ii(0x17_acbc, 1); push(ax);                                 /* push ax */
            ii(0x17_acbd, 1); push(ds);                                 /* push ds */
            ii(0x17_acbe, 3); push(0x136b);                             /* push 0x136b */
            ii(0x17_acc1, 1); nop();                                    /* nop */
            ii(0x17_acc2, 1); push(cs);                                 /* push cs */
            ii(0x17_acc3, 3); call(0x18_104f, 0x6389);                  /* call 0x104f */
            ii(0x17_acc6, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x17_acc9, 3); mov(ax, memw[ds, 0x1fb0]);                /* mov ax, [0x1fb0] */
            ii(0x17_accc, 4); mov(dx, memw[ds, 0x1fb2]);                /* mov dx, [0x1fb2] */
            ii(0x17_acd0, 3); sub(ax, memw[ss, bp - 0x4]);              /* sub ax, [bp-0x4] */
            ii(0x17_acd3, 3); sbb(dx, memw[ss, bp - 0x2]);              /* sbb dx, [bp-0x2] */
            ii(0x17_acd6, 2); or(dx, dx);                               /* or dx, dx */
            ii(0x17_acd8, 2); if(jge(0x17_acf4, 0x1a)) goto l_0x17_acf4; /* jge 0xacf4 */
            ii(0x17_acda, 3); les(bx, memw[ss, bp + 0x6]);              /* les bx, [bp+0x6] */
            ii(0x17_acdd, 6); mov(memw[es, bx + 0x20], 0x8013);         /* mov word [es:bx+0x20], 0x8013 */
            ii(0x17_ace3, 6); mov(memw[es, bx + 0x22], 0);              /* mov word [es:bx+0x22], 0x0 */
            ii(0x17_ace9, 5); or(memb[es, bx + 0x2c], 0x1);             /* or byte [es:bx+0x2c], 0x1 */
            ii(0x17_acee, 1); pop(ds);                                  /* pop ds */
            ii(0x17_acef, 1); pop(si);                                  /* pop si */
            ii(0x17_acf0, 1); pop(di);                                  /* pop di */
            ii(0x17_acf1, 1); leave();                                  /* leave */
            ii(0x17_acf2, 1); retf(); return;                           /* retf */
        //  ii(0x17_acf3, 1); Недостижимый код.
        l_0x17_acf4:
            ii(0x17_acf4, 5); cmp(memw[ss, bp - 0x6], 0x1000);          /* cmp word [bp-0x6], 0x1000 */
            ii(0x17_acf9, 2); if(jb(0x17_ad17, 0x1c)) goto l_0x17_ad17; /* jb 0xad17 */
            ii(0x17_acfb, 2); if(ja(0x17_acfd, 0)) goto l_0x17_acfd;    /* ja 0xacfd */
        l_0x17_acfd:
            ii(0x17_acfd, 3); mov(ax, memw[ss, bp - 0x8]);              /* mov ax, [bp-0x8] */
            ii(0x17_ad00, 3); mov(dx, memw[ss, bp - 0x6]);              /* mov dx, [bp-0x6] */
            ii(0x17_ad03, 3); add(ax, memw[ss, bp - 0x20]);             /* add ax, [bp-0x20] */
            ii(0x17_ad06, 3); adc(dx, memw[ss, bp - 0x1e]);             /* adc dx, [bp-0x1e] */
            ii(0x17_ad09, 4); cmp(dx, memw[ds, 0x4fda]);                /* cmp dx, [0x4fda] */
            ii(0x17_ad0d, 2); if(jb(0x17_ad1c, 0xd)) goto l_0x17_ad1c;  /* jb 0xad1c */
            ii(0x17_ad0f, 2); if(ja(0x17_ad17, 0x6)) goto l_0x17_ad17;  /* ja 0xad17 */
            ii(0x17_ad11, 4); cmp(ax, memw[ds, 0x4fd8]);                /* cmp ax, [0x4fd8] */
            ii(0x17_ad15, 2); if(jbe(0x17_ad1c, 0x5)) goto l_0x17_ad1c; /* jbe 0xad1c */
        l_0x17_ad17:
            ii(0x17_ad17, 1); pop(ds);                                  /* pop ds */
            ii(0x17_ad18, 1); pop(si);                                  /* pop si */
            ii(0x17_ad19, 1); pop(di);                                  /* pop di */
            ii(0x17_ad1a, 1); leave();                                  /* leave */
            ii(0x17_ad1b, 1); retf(); return;                           /* retf */
        l_0x17_ad1c:
            ii(0x17_ad1c, 3); mov(ax, memw[ss, bp - 0x8]);              /* mov ax, [bp-0x8] */
            ii(0x17_ad1f, 3); mov(dx, memw[ss, bp - 0x6]);              /* mov dx, [bp-0x6] */
            ii(0x17_ad22, 3); sub(ax, 0);                               /* sub ax, 0x0 */
            ii(0x17_ad25, 4); sbb(dx, 0x1000);                          /* sbb dx, 0x1000 */
            ii(0x17_ad29, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x17_ad2b, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x17_ad2d, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x17_ad2f, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x17_ad31, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_ad33, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_ad35, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_ad37, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_ad39, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_ad3b, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_ad3d, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_ad3f, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_ad41, 3); mov(memw[ss, bp - 0x16], ax);             /* mov [bp-0x16], ax */
            ii(0x17_ad44, 3); mov(memw[ss, bp - 0x14], dx);             /* mov [bp-0x14], dx */
            ii(0x17_ad47, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_ad49, 3); mov(memw[ss, bp - 0x18], ax);             /* mov [bp-0x18], ax */
            ii(0x17_ad4c, 3); mov(memw[ss, bp - 0x1a], ax);             /* mov [bp-0x1a], ax */
            ii(0x17_ad4f, 2); jmp(0x17_ad62, 0x11); goto l_0x17_ad62;   /* jmp 0xad62 */
        //  ii(0x17_ad51, 1); nop();                                    /* nop */
        l_0x17_ad52:
            ii(0x17_ad52, 4); add(memw[ss, bp - 0x1a], 0x1);            /* add word [bp-0x1a], 0x1 */
            ii(0x17_ad56, 4); adc(memw[ss, bp - 0x18], 0);              /* adc word [bp-0x18], 0x0 */
            ii(0x17_ad5a, 4); add(memw[ss, bp - 0x16], 0x1);            /* add word [bp-0x16], 0x1 */
            ii(0x17_ad5e, 4); adc(memw[ss, bp - 0x14], 0);              /* adc word [bp-0x14], 0x0 */
        l_0x17_ad62:
            ii(0x17_ad62, 3); mov(ax, memw[ss, bp - 0x1a]);             /* mov ax, [bp-0x1a] */
            ii(0x17_ad65, 3); mov(dx, memw[ss, bp - 0x18]);             /* mov dx, [bp-0x18] */
            ii(0x17_ad68, 3); cmp(memw[ss, bp - 0x2], dx);              /* cmp [bp-0x2], dx */
            ii(0x17_ad6b, 2); if(jae(0x17_ad70, 0x3)) goto l_0x17_ad70; /* jae 0xad70 */
            ii(0x17_ad6d, 3); jmp(0x17_af38, 0x1c8); goto l_0x17_af38;  /* jmp 0xaf38 */
        l_0x17_ad70:
            ii(0x17_ad70, 2); if(ja(0x17_ad7a, 0x8)) goto l_0x17_ad7a;  /* ja 0xad7a */
            ii(0x17_ad72, 3); cmp(memw[ss, bp - 0x4], ax);              /* cmp [bp-0x4], ax */
            ii(0x17_ad75, 2); if(ja(0x17_ad7a, 0x3)) goto l_0x17_ad7a;  /* ja 0xad7a */
            ii(0x17_ad77, 3); jmp(0x17_af38, 0x1be); goto l_0x17_af38;  /* jmp 0xaf38 */
        l_0x17_ad7a:
            ii(0x17_ad7a, 3); mov(ax, memw[ss, bp - 0x16]);             /* mov ax, [bp-0x16] */
            ii(0x17_ad7d, 3); mov(dx, memw[ss, bp - 0x14]);             /* mov dx, [bp-0x14] */
            ii(0x17_ad80, 3); add(ax, 0);                               /* add ax, 0x0 */
            ii(0x17_ad83, 3); adc(dx, 0x1);                             /* adc dx, 0x1 */
            ii(0x17_ad86, 3); mov(memw[ss, bp - 0x12], ax);             /* mov [bp-0x12], ax */
            ii(0x17_ad89, 3); mov(memw[ss, bp - 0x10], dx);             /* mov [bp-0x10], dx */
            ii(0x17_ad8c, 3); push(memw[ss, bp - 0x14]);                /* push word [bp-0x14] */
            ii(0x17_ad8f, 3); push(memw[ss, bp - 0x16]);                /* push word [bp-0x16] */
            ii(0x17_ad92, 4); push(memw[ds, 0x4ff6]);                   /* push word [0x4ff6] */
            ii(0x17_ad96, 4); push(memw[ds, 0x4ff4]);                   /* push word [0x4ff4] */
            ii(0x17_ad9a, 3); call(0x17_90c4, -0x1cd9);                 /* call 0x90c4 */
            ii(0x17_ad9d, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x17_ada0, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_ada2, 2); if(jnz(0x17_ada7, 0x3)) goto l_0x17_ada7; /* jnz 0xada7 */
            ii(0x17_ada4, 3); jmp(0x17_af26, 0x17f); goto l_0x17_af26;  /* jmp 0xaf26 */
        l_0x17_ada7:
            ii(0x17_ada7, 3); push(memw[ss, bp - 0x14]);                /* push word [bp-0x14] */
            ii(0x17_adaa, 3); push(memw[ss, bp - 0x16]);                /* push word [bp-0x16] */
            ii(0x17_adad, 4); push(memw[ds, 0x4f8e]);                   /* push word [0x4f8e] */
            ii(0x17_adb1, 4); push(memw[ds, 0x4f8c]);                   /* push word [0x4f8c] */
            ii(0x17_adb5, 3); call(0x17_9208, -0x1bb0);                 /* call 0x9208 */
            ii(0x17_adb8, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x17_adbb, 3); mov(memw[ss, bp - 0xc], ax);              /* mov [bp-0xc], ax */
            ii(0x17_adbe, 3); mov(memw[ss, bp - 0xa], dx);              /* mov [bp-0xa], dx */
            ii(0x17_adc1, 4); test(memb[ss, bp - 0xc], 0x1);            /* test byte [bp-0xc], 0x1 */
            ii(0x17_adc5, 2); if(jz(0x17_ade8, 0x21)) goto l_0x17_ade8; /* jz 0xade8 */
            ii(0x17_adc7, 3); push(memw[ss, bp - 0x10]);                /* push word [bp-0x10] */
            ii(0x17_adca, 3); push(memw[ss, bp - 0x12]);                /* push word [bp-0x12] */
            ii(0x17_adcd, 1); nop();                                    /* nop */
            ii(0x17_adce, 1); push(cs);                                 /* push cs */
            ii(0x17_adcf, 3); call(0x17_901a, -0x1db8);                 /* call 0x901a */
            ii(0x17_add2, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_add5, 3); mov(memw[ss, bp - 0x1c], ax);             /* mov [bp-0x1c], ax */
            ii(0x17_add8, 4); les(bx, memw[ds, 0x4f9c]);                /* les bx, [0x4f9c] */
            ii(0x17_addc, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x17_adde, 4); test(memb[es, bx + si], 0x80);            /* test byte [es:bx+si], 0x80 */
            ii(0x17_ade2, 2); if(jz(0x17_ade8, 0x4)) goto l_0x17_ade8;  /* jz 0xade8 */
            ii(0x17_ade4, 3); jmp(0x17_af19, 0x132); goto l_0x17_af19;  /* jmp 0xaf19 */
        //  ii(0x17_ade7, 1); nop();                                    /* nop */
        l_0x17_ade8:
            ii(0x17_ade8, 1); nop();                                    /* nop */
            ii(0x17_ade9, 1); push(cs);                                 /* push cs */
            ii(0x17_adea, 3); call(0x17_790e, -0x34df);                 /* call 0x790e */
            ii(0x17_aded, 3); mov(memw[ss, bp - 0x1c], ax);             /* mov [bp-0x1c], ax */
            ii(0x17_adf0, 3); cmp(ax, 0xffff);                          /* cmp ax, 0xffff */
            ii(0x17_adf3, 2); if(jnz(0x17_ae1a, 0x25)) goto l_0x17_ae1a; /* jnz 0xae1a */
            ii(0x17_adf5, 1); push(ds);                                 /* push ds */
            ii(0x17_adf6, 3); push(0x1383);                             /* push 0x1383 */
            ii(0x17_adf9, 1); nop();                                    /* nop */
            ii(0x17_adfa, 1); push(cs);                                 /* push cs */
            ii(0x17_adfb, 3); call(0x18_104f, 0x6251);                  /* call 0x104f */
            ii(0x17_adfe, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_ae01, 3); les(bx, memw[ss, bp + 0x6]);              /* les bx, [bp+0x6] */
            ii(0x17_ae04, 6); mov(memw[es, bx + 0x20], 0x8013);         /* mov word [es:bx+0x20], 0x8013 */
            ii(0x17_ae0a, 6); mov(memw[es, bx + 0x22], 0);              /* mov word [es:bx+0x22], 0x0 */
            ii(0x17_ae10, 5); or(memb[es, bx + 0x2c], 0x1);             /* or byte [es:bx+0x2c], 0x1 */
            ii(0x17_ae15, 1); pop(ds);                                  /* pop ds */
            ii(0x17_ae16, 1); pop(si);                                  /* pop si */
            ii(0x17_ae17, 1); pop(di);                                  /* pop di */
            ii(0x17_ae18, 1); leave();                                  /* leave */
            ii(0x17_ae19, 1); retf(); return;                           /* retf */
        l_0x17_ae1a:
            ii(0x17_ae1a, 3); push(memw[ss, bp - 0x14]);                /* push word [bp-0x14] */
            ii(0x17_ae1d, 3); push(memw[ss, bp - 0x16]);                /* push word [bp-0x16] */
            ii(0x17_ae20, 4); push(memw[ds, 0x4f8e]);                   /* push word [0x4f8e] */
            ii(0x17_ae24, 4); push(memw[ds, 0x4f8c]);                   /* push word [0x4f8c] */
            ii(0x17_ae28, 3); call(0x17_9208, -0x1c23);                 /* call 0x9208 */
            ii(0x17_ae2b, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x17_ae2e, 3); mov(memw[ss, bp - 0xc], ax);              /* mov [bp-0xc], ax */
            ii(0x17_ae31, 3); mov(memw[ss, bp - 0xa], dx);              /* mov [bp-0xa], dx */
            ii(0x17_ae34, 4); test(memb[ss, bp - 0xc], 0x1);            /* test byte [bp-0xc], 0x1 */
            ii(0x17_ae38, 2); if(jnz(0x17_ae64, 0x2a)) goto l_0x17_ae64; /* jnz 0xae64 */
            ii(0x17_ae3a, 2); push(0);                                  /* push 0x0 */
            ii(0x17_ae3c, 3); push(memw[ss, bp - 0x1c]);                /* push word [bp-0x1c] */
            ii(0x17_ae3f, 3); push(memw[ss, bp - 0x10]);                /* push word [bp-0x10] */
            ii(0x17_ae42, 3); push(memw[ss, bp - 0x12]);                /* push word [bp-0x12] */
            ii(0x17_ae45, 1); nop();                                    /* nop */
            ii(0x17_ae46, 1); push(cs);                                 /* push cs */
            ii(0x17_ae47, 3); call(0x17_7dac, -0x309e);                 /* call 0x7dac */
            ii(0x17_ae4a, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x17_ae4d, 3); push(memw[ss, bp - 0xa]);                 /* push word [bp-0xa] */
            ii(0x17_ae50, 3); push(memw[ss, bp - 0xc]);                 /* push word [bp-0xc] */
            ii(0x17_ae53, 3); push(memw[ss, bp - 0x10]);                /* push word [bp-0x10] */
            ii(0x17_ae56, 3); push(memw[ss, bp - 0x12]);                /* push word [bp-0x12] */
            ii(0x17_ae59, 1); nop();                                    /* nop */
            ii(0x17_ae5a, 1); push(cs);                                 /* push cs */
            ii(0x17_ae5b, 3); call(0x17_7cfc, -0x3162);                 /* call 0x7cfc */
            ii(0x17_ae5e, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x17_ae61, 3); jmp(0x17_af19, 0xb5); goto l_0x17_af19;   /* jmp 0xaf19 */
        l_0x17_ae64:
            ii(0x17_ae64, 3); push(memw[ss, bp - 0x10]);                /* push word [bp-0x10] */
            ii(0x17_ae67, 3); push(memw[ss, bp - 0x12]);                /* push word [bp-0x12] */
            ii(0x17_ae6a, 1); nop();                                    /* nop */
            ii(0x17_ae6b, 1); push(cs);                                 /* push cs */
            ii(0x17_ae6c, 3); call(0x17_901a, -0x1e55);                 /* call 0x901a */
            ii(0x17_ae6f, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_ae72, 3); mov(memw[ss, bp - 0xe], ax);              /* mov [bp-0xe], ax */
            ii(0x17_ae75, 2); push(0);                                  /* push 0x0 */
            ii(0x17_ae77, 1); push(ax);                                 /* push ax */
            ii(0x17_ae78, 3); mov(ax, memw[ds, 0x4fd8]);                /* mov ax, [0x4fd8] */
            ii(0x17_ae7b, 4); mov(dx, memw[ds, 0x4fda]);                /* mov dx, [0x4fda] */
            ii(0x17_ae7f, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x17_ae81, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x17_ae83, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x17_ae85, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x17_ae87, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_ae89, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_ae8b, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_ae8d, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_ae8f, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_ae91, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_ae93, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_ae95, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_ae97, 1); push(dx);                                 /* push dx */
            ii(0x17_ae98, 1); push(ax);                                 /* push ax */
            ii(0x17_ae99, 1); nop();                                    /* nop */
            ii(0x17_ae9a, 1); push(cs);                                 /* push cs */
            ii(0x17_ae9b, 3); call(0x17_7dac, -0x30f2);                 /* call 0x7dac */
            ii(0x17_ae9e, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x17_aea1, 2); push(0);                                  /* push 0x0 */
            ii(0x17_aea3, 3); push(memw[ss, bp - 0x1c]);                /* push word [bp-0x1c] */
            ii(0x17_aea6, 3); push(memw[ss, bp - 0x10]);                /* push word [bp-0x10] */
            ii(0x17_aea9, 3); push(memw[ss, bp - 0x12]);                /* push word [bp-0x12] */
            ii(0x17_aeac, 1); nop();                                    /* nop */
            ii(0x17_aead, 1); push(cs);                                 /* push cs */
            ii(0x17_aeae, 3); call(0x17_7dac, -0x3105);                 /* call 0x7dac */
            ii(0x17_aeb1, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x17_aeb4, 3); mov(ax, memw[ds, 0x4fd8]);                /* mov ax, [0x4fd8] */
            ii(0x17_aeb7, 4); mov(dx, memw[ds, 0x4fda]);                /* mov dx, [0x4fda] */
            ii(0x17_aebb, 3); and(ax, 0xf000);                          /* and ax, 0xf000 */
            ii(0x17_aebe, 1); push(dx);                                 /* push dx */
            ii(0x17_aebf, 1); push(ax);                                 /* push ax */
            ii(0x17_aec0, 1); nop();                                    /* nop */
            ii(0x17_aec1, 1); push(cs);                                 /* push cs */
            ii(0x17_aec2, 3); call(0x17_8988, -0x253d);                 /* call 0x8988 */
            ii(0x17_aec5, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_aec8, 3); mov(ax, memw[ss, bp - 0x12]);             /* mov ax, [bp-0x12] */
            ii(0x17_aecb, 3); mov(dx, memw[ss, bp - 0x10]);             /* mov dx, [bp-0x10] */
            ii(0x17_aece, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x17_aed0, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x17_aed2, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x17_aed4, 2); sub(al, al);                              /* sub al, al */
            ii(0x17_aed6, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_aed8, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_aeda, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_aedc, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_aede, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_aee0, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_aee2, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_aee4, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_aee6, 1); push(dx);                                 /* push dx */
            ii(0x17_aee7, 1); push(ax);                                 /* push ax */
            ii(0x17_aee8, 4); push(memw[ds, 0x1fea]);                   /* push word [0x1fea] */
            ii(0x17_aeec, 1); nop();                                    /* nop */
            ii(0x17_aeed, 1); push(cs);                                 /* push cs */
            ii(0x17_aeee, 3); call(0x17_89bc, -0x2535);                 /* call 0x89bc */
            ii(0x17_aef1, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x17_aef4, 1); push(ds);                                 /* push ds */
            ii(0x17_aef5, 1); push(es);                                 /* push es */
            ii(0x17_aef6, 3); mov(cx, 0x400);                           /* mov cx, 0x400 */
            ii(0x17_aef9, 4); les(di, memw[ds, 0x1fe8]);                /* les di, [0x1fe8] */
            ii(0x17_aefd, 4); lds(si, memw[ds, 0x4fb8]);                /* lds si, [0x4fb8] */
            ii(0x17_af01, 3); rep(() => movsd());                       /* rep movsd */
            ii(0x17_af04, 1); pop(es);                                  /* pop es */
            ii(0x17_af05, 1); pop(ds);                                  /* pop ds */
            ii(0x17_af06, 3); mov(bx, memw[ss, bp - 0xe]);              /* mov bx, [bp-0xe] */
            ii(0x17_af09, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x17_af0c, 4); les(si, memw[ds, 0x4fa4]);                /* les si, [0x4fa4] */
            ii(0x17_af10, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_af12, 4); mov(memw[es, bx + si + 0x2], ax);         /* mov [es:bx+si+0x2], ax */
            ii(0x17_af16, 3); mov(memw[es, bx + si], ax);               /* mov [es:bx+si], ax */
        l_0x17_af19:
            ii(0x17_af19, 3); push(memw[ss, bp - 0x1c]);                /* push word [bp-0x1c] */
            ii(0x17_af1c, 1); nop();                                    /* nop */
            ii(0x17_af1d, 1); push(cs);                                 /* push cs */
            ii(0x17_af1e, 3); call(0x17_7e98, -0x3089);                 /* call 0x7e98 */
            ii(0x17_af21, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x17_af24, 2); jmp(0x17_af34, 0xe); goto l_0x17_af34;    /* jmp 0xaf34 */
        l_0x17_af26:
            ii(0x17_af26, 3); les(bx, memw[ss, bp + 0x6]);              /* les bx, [bp+0x6] */
            ii(0x17_af29, 5); and(memb[es, bx + 0x2c], -0x2 /* 0xfe */); /* and byte [es:bx+0x2c], 0xfe */
            ii(0x17_af2e, 1); pop(ds);                                  /* pop ds */
            ii(0x17_af2f, 1); pop(si);                                  /* pop si */
            ii(0x17_af30, 1); pop(di);                                  /* pop di */
            ii(0x17_af31, 1); leave();                                  /* leave */
            ii(0x17_af32, 1); retf(); return;                           /* retf */
        //  ii(0x17_af33, 1); Недостижимый код.
        l_0x17_af34:
            ii(0x17_af34, 3); jmp(0x17_ad52, -0x1e5); goto l_0x17_ad52; /* jmp 0xad52 */
        //  ii(0x17_af37, 1); nop();                                    /* nop */
        l_0x17_af38:
            ii(0x17_af38, 3); les(bx, memw[ss, bp + 0x6]);              /* les bx, [bp+0x6] */
            ii(0x17_af3b, 5); and(memb[es, bx + 0x2c], -0x2 /* 0xfe */); /* and byte [es:bx+0x2c], 0xfe */
            ii(0x17_af40, 1); pop(ds);                                  /* pop ds */
            ii(0x17_af41, 1); pop(si);                                  /* pop si */
            ii(0x17_af42, 1); pop(di);                                  /* pop di */
            ii(0x17_af43, 1); leave();                                  /* leave */
            ii(0x17_af44, 1); retf();                                   /* retf */
        }
    }
}
