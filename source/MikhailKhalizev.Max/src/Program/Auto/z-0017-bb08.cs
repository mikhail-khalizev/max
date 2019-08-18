using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_bb08-4a1b11f")]
        public void Method_0017_bb08()
        {
            ii(0x17_bb08, 4); enterw(0x14, 0);                          /* enter 0x14, 0x0 */
            ii(0x17_bb0c, 1); pushw(ds);                                /* push ds */
            ii(0x17_bb0d, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_bb10, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_bb12, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_bb14, 3); mov(memw_a16[ss, bp - 0xe], ax);          /* mov [bp-0xe], ax */
            ii(0x17_bb17, 3); mov(memw_a16[ss, bp - 0x10], ax);         /* mov [bp-0x10], ax */
            ii(0x17_bb1a, 3); mov(memw_a16[ss, bp - 0x12], ax);         /* mov [bp-0x12], ax */
            ii(0x17_bb1d, 3); mov(memw_a16[ss, bp - 0x14], ax);         /* mov [bp-0x14], ax */
            ii(0x17_bb20, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x17_bb23, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x17_bb26, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x17_bb29, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x17_bb2c, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x17_bb2f, 3); mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x17_bb32, 2); jmpw(0x17_bb3c, 0x8); goto l_0x17_bb3c;   /* jmp 0xbb3c */
        l_0x17_bb34:
            ii(0x17_bb34, 4); add(memw_a16[ss, bp - 0xc], 0x1);         /* add word [bp-0xc], 0x1 */
            ii(0x17_bb38, 4); adc(memw_a16[ss, bp - 0xa], 0);           /* adc word [bp-0xa], 0x0 */
        l_0x17_bb3c:
            ii(0x17_bb3c, 3); mov(ax, memw_a16[ds, 0x4fd0]);            /* mov ax, [0x4fd0] */
            ii(0x17_bb3f, 4); mov(dx, memw_a16[ds, 0x4fd2]);            /* mov dx, [0x4fd2] */
            ii(0x17_bb43, 3); cmp(memw_a16[ss, bp - 0xa], dx);          /* cmp [bp-0xa], dx */
            ii(0x17_bb46, 2); if(jaw(0x17_bbbc, 0x74)) goto l_0x17_bbbc; /* ja 0xbbbc */
            ii(0x17_bb48, 2); if(jbw(0x17_bb4f, 0x5)) goto l_0x17_bb4f; /* jb 0xbb4f */
            ii(0x17_bb4a, 3); cmp(memw_a16[ss, bp - 0xc], ax);          /* cmp [bp-0xc], ax */
            ii(0x17_bb4d, 2); if(jaew(0x17_bbbc, 0x6d)) goto l_0x17_bbbc; /* jae 0xbbbc */
        l_0x17_bb4f:
            ii(0x17_bb4f, 3); pushw(memw_a16[ss, bp - 0xa]);            /* push word [bp-0xa] */
            ii(0x17_bb52, 3); pushw(memw_a16[ss, bp - 0xc]);            /* push word [bp-0xc] */
            ii(0x17_bb55, 4); pushw(memw_a16[ds, 0x4ff6]);              /* push word [0x4ff6] */
            ii(0x17_bb59, 4); pushw(memw_a16[ds, 0x4ff4]);              /* push word [0x4ff4] */
            ii(0x17_bb5d, 3); callw(0x17_90c4, -0x2a9c);                /* call 0x90c4 */
            ii(0x17_bb60, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x17_bb63, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_bb65, 2); if(jnzw(0x17_bb86, 0x1f)) goto l_0x17_bb86; /* jnz 0xbb86 */
            ii(0x17_bb67, 4); add(memw_a16[ss, bp - 0x14], 0x1);        /* add word [bp-0x14], 0x1 */
            ii(0x17_bb6b, 4); adc(memw_a16[ss, bp - 0x12], 0);          /* adc word [bp-0x12], 0x0 */
            ii(0x17_bb6f, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x17_bb72, 3); or(ax, memw_a16[ss, bp - 0x4]);           /* or ax, [bp-0x4] */
            ii(0x17_bb75, 2); if(jnzw(0x17_bb83, 0xc)) goto l_0x17_bb83; /* jnz 0xbb83 */
            ii(0x17_bb77, 3); mov(ax, memw_a16[ss, bp - 0xc]);          /* mov ax, [bp-0xc] */
            ii(0x17_bb7a, 3); mov(dx, memw_a16[ss, bp - 0xa]);          /* mov dx, [bp-0xa] */
            ii(0x17_bb7d, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x17_bb80, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
        l_0x17_bb83:
            ii(0x17_bb83, 2); jmpw(0x17_bbb8, 0x33); goto l_0x17_bbb8;  /* jmp 0xbbb8 */
        //    ii(0x17_bb85, 1); nop();                                    /* nop */
        l_0x17_bb86:
            ii(0x17_bb86, 3); mov(ax, memw_a16[ss, bp - 0x14]);         /* mov ax, [bp-0x14] */
            ii(0x17_bb89, 3); mov(dx, memw_a16[ss, bp - 0x12]);         /* mov dx, [bp-0x12] */
            ii(0x17_bb8c, 3); cmp(memw_a16[ss, bp - 0xe], dx);          /* cmp [bp-0xe], dx */
            ii(0x17_bb8f, 2); if(jaw(0x17_bbaa, 0x19)) goto l_0x17_bbaa; /* ja 0xbbaa */
            ii(0x17_bb91, 2); if(jbw(0x17_bb98, 0x5)) goto l_0x17_bb98; /* jb 0xbb98 */
            ii(0x17_bb93, 3); cmp(memw_a16[ss, bp - 0x10], ax);         /* cmp [bp-0x10], ax */
            ii(0x17_bb96, 2); if(jaew(0x17_bbaa, 0x12)) goto l_0x17_bbaa; /* jae 0xbbaa */
        l_0x17_bb98:
            ii(0x17_bb98, 3); mov(memw_a16[ss, bp - 0x10], ax);         /* mov [bp-0x10], ax */
            ii(0x17_bb9b, 3); mov(memw_a16[ss, bp - 0xe], dx);          /* mov [bp-0xe], dx */
            ii(0x17_bb9e, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x17_bba1, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x17_bba4, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x17_bba7, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
        l_0x17_bbaa:
            ii(0x17_bbaa, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_bbac, 3); mov(memw_a16[ss, bp - 0x12], ax);         /* mov [bp-0x12], ax */
            ii(0x17_bbaf, 3); mov(memw_a16[ss, bp - 0x14], ax);         /* mov [bp-0x14], ax */
            ii(0x17_bbb2, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x17_bbb5, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
        l_0x17_bbb8:
            ii(0x17_bbb8, 3); jmpw(0x17_bb34, -0x87); goto l_0x17_bb34; /* jmp 0xbb34 */
        //    ii(0x17_bbbb, 1); nop();                                    /* nop */
        l_0x17_bbbc:
            ii(0x17_bbbc, 3); mov(ax, memw_a16[ss, bp - 0x14]);         /* mov ax, [bp-0x14] */
            ii(0x17_bbbf, 3); mov(dx, memw_a16[ss, bp - 0x12]);         /* mov dx, [bp-0x12] */
            ii(0x17_bbc2, 3); cmp(memw_a16[ss, bp - 0xe], dx);          /* cmp [bp-0xe], dx */
            ii(0x17_bbc5, 2); if(jaw(0x17_bbd4, 0xd)) goto l_0x17_bbd4; /* ja 0xbbd4 */
            ii(0x17_bbc7, 2); if(jbw(0x17_bbce, 0x5)) goto l_0x17_bbce; /* jb 0xbbce */
            ii(0x17_bbc9, 3); cmp(memw_a16[ss, bp - 0x10], ax);         /* cmp [bp-0x10], ax */
            ii(0x17_bbcc, 2); if(jaew(0x17_bbd4, 0x6)) goto l_0x17_bbd4; /* jae 0xbbd4 */
        l_0x17_bbce:
            ii(0x17_bbce, 3); mov(memw_a16[ss, bp - 0x10], ax);         /* mov [bp-0x10], ax */
            ii(0x17_bbd1, 3); mov(memw_a16[ss, bp - 0xe], dx);          /* mov [bp-0xe], dx */
        l_0x17_bbd4:
            ii(0x17_bbd4, 3); mov(ax, memw_a16[ss, bp - 0x10]);         /* mov ax, [bp-0x10] */
            ii(0x17_bbd7, 3); mov(dx, memw_a16[ss, bp - 0xe]);          /* mov dx, [bp-0xe] */
            ii(0x17_bbda, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x17_bbdc, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x17_bbde, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x17_bbe0, 2); sub(al, al);                              /* sub al, al */
            ii(0x17_bbe2, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_bbe4, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_bbe6, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_bbe8, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_bbea, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_bbec, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_bbee, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_bbf0, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_bbf2, 1); popw(ds);                                 /* pop ds */
            ii(0x17_bbf3, 1); leavew();                                 /* leave */
            ii(0x17_bbf4, 1); retfw(); return;                          /* retf */
        }
    }
}
