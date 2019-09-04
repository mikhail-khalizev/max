using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_8a37-60fdbeff")]
        public void Method_1011_8a37()
        {
            ii(0x1011_8a37, 5); push(0x28);                             /* push 0x28 */
            ii(0x1011_8a3c, 5); call(Definitions.sys_check_available_stack_size, 0x4_d311); /* call 0x10165d52 */
            ii(0x1011_8a41, 1); push(ecx);                              /* push ecx */
            ii(0x1011_8a42, 1); push(esi);                              /* push esi */
            ii(0x1011_8a43, 1); push(edi);                              /* push edi */
            ii(0x1011_8a44, 1); push(ebp);                              /* push ebp */
            ii(0x1011_8a45, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_8a47, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1011_8a4d, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1011_8a50, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x1011_8a53, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x1011_8a56, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_8a59, 3); mov(ebx, memd[ds, eax + 26]);           /* mov ebx, [eax+0x1a] */
            ii(0x1011_8a5c, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1011_8a5f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_8a62, 3); mov(edx, memd[ds, eax + 24]);           /* mov edx, [eax+0x18] */
            ii(0x1011_8a65, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_8a68, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1011_8a6b, 5); call(0x1007_6aac, -0xa_1fc4);           /* call 0x10076aac */
            ii(0x1011_8a70, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_8a73, 4); test(memb[ds, eax + 18], 0x40);         /* test byte [eax+0x12], 0x40 */
            ii(0x1011_8a77, 2); if(jz(0x1011_8ae3, 0x6a)) goto l_0x1011_8ae3; /* jz 0x10118ae3 */
            ii(0x1011_8a79, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1011_8a7c, 3); mov(edx, memd[ds, eax + 20]);           /* mov edx, [eax+0x14] */
            ii(0x1011_8a7f, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_8a82, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1011_8a85, 4); imul(edx, memd[ds, eax + 37]);          /* imul edx, [eax+0x25] */
            ii(0x1011_8a89, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1011_8a8c, 3); mov(eax, memd[ds, eax + 29]);           /* mov eax, [eax+0x1d] */
            ii(0x1011_8a8f, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_8a91, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1011_8a94, 4); sar(memd[ss, ebp - 16], 0x10);          /* sar dword [ebp-0x10], 0x10 */
            ii(0x1011_8a98, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1011_8a9b, 3); mov(eax, memd[ds, eax + 23]);           /* mov eax, [eax+0x17] */
            ii(0x1011_8a9e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_8aa1, 3); add(memd[ss, ebp - 16], eax);           /* add [ebp-0x10], eax */
            ii(0x1011_8aa4, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1011_8aa7, 3); sar(eax, 6);                            /* sar eax, 0x6 */
            ii(0x1011_8aaa, 4); mov(memw[ss, ebp - 20], ax);            /* mov [ebp-0x14], ax */
            ii(0x1011_8aae, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1011_8ab1, 3); mov(edx, memd[ds, eax + 20]);           /* mov edx, [eax+0x14] */
            ii(0x1011_8ab4, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_8ab7, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1011_8aba, 4); imul(edx, memd[ds, eax + 41]);          /* imul edx, [eax+0x29] */
            ii(0x1011_8abe, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1011_8ac1, 3); mov(eax, memd[ds, eax + 33]);           /* mov eax, [eax+0x21] */
            ii(0x1011_8ac4, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_8ac6, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1011_8ac9, 4); sar(memd[ss, ebp - 16], 0x10);          /* sar dword [ebp-0x10], 0x10 */
            ii(0x1011_8acd, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1011_8ad0, 3); mov(eax, memd[ds, eax + 25]);           /* mov eax, [eax+0x19] */
            ii(0x1011_8ad3, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_8ad6, 3); add(memd[ss, ebp - 16], eax);           /* add [ebp-0x10], eax */
            ii(0x1011_8ad9, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1011_8adc, 3); sar(eax, 6);                            /* sar eax, 0x6 */
            ii(0x1011_8adf, 4); mov(memw[ss, ebp - 18], ax);            /* mov [ebp-0x12], ax */
        l_0x1011_8ae3:
            ii(0x1011_8ae3, 3); lea(edx, memd[ss, ebp - 20]);           /* lea edx, [ebp-0x14] */
            ii(0x1011_8ae6, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_8ae9, 5); call(0x1007_5e64, -0xa_2c8a);           /* call 0x10075e64 */
            ii(0x1011_8aee, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_8af1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_8af3, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_8af4, 1); pop(edi);                               /* pop edi */
            ii(0x1011_8af5, 1); pop(esi);                               /* pop esi */
            ii(0x1011_8af6, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_8af7, 1); ret();                                  /* ret */
        }
    }
}
