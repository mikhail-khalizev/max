using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_cbb0-22513b7f")]
        public void /* sys */ Method_1018_cbb0()
        {
            ii(0x1018_cbb0, 1); push(ebp);                              /* push ebp */
            ii(0x1018_cbb1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1018_cbb3, 1); push(ebx);                              /* push ebx */
            ii(0x1018_cbb4, 1); push(ecx);                              /* push ecx */
            ii(0x1018_cbb5, 1); push(esi);                              /* push esi */
            ii(0x1018_cbb6, 3); sub(esp, 0x34);                         /* sub esp, 0x34 */
            ii(0x1018_cbb9, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1018_cbbb, 2); mov(ecx, edx);                          /* mov ecx, edx */
            ii(0x1018_cbbd, 5); call(/* sys */ 0x1018_c450, -0x772);    /* call 0x1018c450 */
            ii(0x1018_cbc2, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_cbc4, 2); if(jz(0x1018_cc23, 0x5d)) goto l_0x1018_cc23; /* jz 0x1018cc23 */
            ii(0x1018_cbc6, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x1018_cbc9, 5); mov(ebx, 0x32);                         /* mov ebx, 0x32 */
            ii(0x1018_cbce, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_cbd0, 5); call(Definitions.sys_memset, -0x2_6df5); /* call 0x10165de0 */
            ii(0x1018_cbd5, 2); mov(ah, 0x4f);                          /* mov ah, 0x4f */
            ii(0x1018_cbd7, 2); mov(dl, 0x7);                           /* mov dl, 0x7 */
            ii(0x1018_cbd9, 4); mov(memw[ss, ebp - 0x28], si);          /* mov [ebp-0x28], si */
            ii(0x1018_cbdd, 3); mov(memb[ss, ebp - 0x23], ah);          /* mov [ebp-0x23], ah */
            ii(0x1018_cbe0, 3); mov(memb[ss, ebp - 0x24], dl);          /* mov [ebp-0x24], dl */
            ii(0x1018_cbe3, 6); mov(ax, memw[ds, 0x1020_b708]);         /* mov ax, [0x1020b708] */
            ii(0x1018_cbe9, 5); mov(edx, 0x800);                        /* mov edx, 0x800 */
            ii(0x1018_cbee, 4); mov(memw[ss, ebp - 0x10], ax);          /* mov [ebp-0x10], ax */
            ii(0x1018_cbf2, 4); mov(memw[ss, ebp - 0x12], dx);          /* mov [ebp-0x12], dx */
            ii(0x1018_cbf6, 2); xor(dh, dh);                            /* xor dh, dh */
            ii(0x1018_cbf8, 5); mov(eax, 0x10);                         /* mov eax, 0x10 */
            ii(0x1018_cbfd, 3); mov(memb[ss, ebp - 0x2f], dh);          /* mov [ebp-0x2f], dh */
            ii(0x1018_cc00, 3); mov(memb[ss, ebp - 0x30], dh);          /* mov [ebp-0x30], dh */
            ii(0x1018_cc03, 3); lea(edx, ebp - 0x40);                   /* lea edx, [ebp-0x40] */
            ii(0x1018_cc06, 4); mov(memw[ss, ebp - 0x2c], cx);          /* mov [ebp-0x2c], cx */
            ii(0x1018_cc0a, 5); call(/* sys */ 0x1019_4540, 0x7931);    /* call 0x10194540 */
            ii(0x1018_cc0f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_cc11, 2); if(jz(0x1018_cc1a, 0x7)) goto l_0x1018_cc1a; /* jz 0x1018cc1a */
            ii(0x1018_cc13, 5); cmp(memw[ss, ebp - 0x24], 0x4f);        /* cmp word [ebp-0x24], 0x4f */
            ii(0x1018_cc18, 2); if(jz(0x1018_cc1e, 0x4)) goto l_0x1018_cc1e; /* jz 0x1018cc1e */
        l_0x1018_cc1a:
            ii(0x1018_cc1a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_cc1c, 2); jmp(0x1018_cc23, 0x5); goto l_0x1018_cc23; /* jmp 0x1018cc23 */
        l_0x1018_cc1e:
            ii(0x1018_cc1e, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
        l_0x1018_cc23:
            ii(0x1018_cc23, 3); lea(esp, ebp - 0xc);                    /* lea esp, [ebp-0xc] */
            ii(0x1018_cc26, 1); pop(esi);                               /* pop esi */
            ii(0x1018_cc27, 1); pop(ecx);                               /* pop ecx */
            ii(0x1018_cc28, 1); pop(ebx);                               /* pop ebx */
            ii(0x1018_cc29, 1); pop(ebp);                               /* pop ebp */
            ii(0x1018_cc2a, 1); ret();                                  /* ret */
        }
    }
}
