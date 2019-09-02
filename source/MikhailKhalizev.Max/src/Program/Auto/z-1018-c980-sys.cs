using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_c980-f537ccc4")]
        public void /* sys */ Method_1018_c980()
        {
            ii(0x1018_c980, 1); push(ebp);                              /* push ebp */
            ii(0x1018_c981, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1018_c983, 3); sub(esp, 0x34);                         /* sub esp, 0x34 */
            ii(0x1018_c986, 5); call(/* sys */ 0x1018_c450, -0x53b);    /* call 0x1018c450 */
            ii(0x1018_c98b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_c98d, 2); if(jz(0x1018_c9f0, 0x61)) goto l_0x1018_c9f0; /* jz 0x1018c9f0 */
            ii(0x1018_c98f, 3); lea(eax, memd[ss, ebp - 52]);           /* lea eax, [ebp-0x34] */
            ii(0x1018_c992, 5); mov(ebx, 0x32);                         /* mov ebx, 0x32 */
            ii(0x1018_c997, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_c999, 5); call(Definitions.sys_memset, -0x2_6bbe); /* call 0x10165de0 */
            ii(0x1018_c99e, 2); mov(ah, 0x4f);                          /* mov ah, 0x4f */
            ii(0x1018_c9a0, 2); mov(dl, 5);                             /* mov dl, 0x5 */
            ii(0x1018_c9a2, 3); mov(memb[ss, ebp - 23], ah);            /* mov [ebp-0x17], ah */
            ii(0x1018_c9a5, 3); mov(memb[ss, ebp - 24], dl);            /* mov [ebp-0x18], dl */
            ii(0x1018_c9a8, 6); mov(ax, memw[ds, 0x1020_b708]);         /* mov ax, [0x1020b708] */
            ii(0x1018_c9ae, 5); mov(edx, 0x800);                        /* mov edx, 0x800 */
            ii(0x1018_c9b3, 4); mov(memw[ss, ebp - 4], ax);             /* mov [ebp-0x4], ax */
            ii(0x1018_c9b7, 4); mov(memw[ss, ebp - 6], dx);             /* mov [ebp-0x6], dx */
            ii(0x1018_c9bb, 2); xor(dh, dh);                            /* xor dh, dh */
            ii(0x1018_c9bd, 3); mov(al, memb[ss, ebp + 8]);             /* mov al, [ebp+0x8] */
            ii(0x1018_c9c0, 3); mov(memb[ss, ebp - 35], dh);            /* mov [ebp-0x23], dh */
            ii(0x1018_c9c3, 3); mov(memb[ss, ebp - 36], al);            /* mov [ebp-0x24], al */
            ii(0x1018_c9c6, 3); mov(eax, memd[ss, ebp + 12]);           /* mov eax, [ebp+0xc] */
            ii(0x1018_c9c9, 3); lea(edx, memd[ss, ebp - 52]);           /* lea edx, [ebp-0x34] */
            ii(0x1018_c9cc, 4); mov(memw[ss, ebp - 32], ax);            /* mov [ebp-0x20], ax */
            ii(0x1018_c9d0, 5); mov(eax, 0x10);                         /* mov eax, 0x10 */
            ii(0x1018_c9d5, 5); call(/* sys */ 0x1019_4540, 0x7b66);    /* call 0x10194540 */
            ii(0x1018_c9da, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_c9dc, 2); if(jz(0x1018_c9e5, 7)) goto l_0x1018_c9e5; /* jz 0x1018c9e5 */
            ii(0x1018_c9de, 5); cmp(memw[ss, ebp - 24], 0x4f);          /* cmp word [ebp-0x18], 0x4f */
            ii(0x1018_c9e3, 2); if(jz(0x1018_c9eb, 6)) goto l_0x1018_c9eb; /* jz 0x1018c9eb */
        l_0x1018_c9e5:
            ii(0x1018_c9e5, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_c9e7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1018_c9e9, 1); pop(ebp);                               /* pop ebp */
            ii(0x1018_c9ea, 1); ret(); return;                          /* ret */
        l_0x1018_c9eb:
            ii(0x1018_c9eb, 5); mov(eax, 1);                            /* mov eax, 0x1 */
        l_0x1018_c9f0:
            ii(0x1018_c9f0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1018_c9f2, 1); pop(ebp);                               /* pop ebp */
            ii(0x1018_c9f3, 1); ret();                                  /* ret */
        }
    }
}
