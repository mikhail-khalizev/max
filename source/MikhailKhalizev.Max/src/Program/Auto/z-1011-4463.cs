using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_4463-e37ce542")]
        public void Method_1011_4463()
        {
            ii(0x1011_4463, 5); push(0x20);                             /* push 0x20 */
            ii(0x1011_4468, 5); call(Definitions.sys_check_available_stack_size, 0x5_18e5); /* call 0x10165d52 */
            ii(0x1011_446d, 1); push(ebx);                              /* push ebx */
            ii(0x1011_446e, 1); push(ecx);                              /* push ecx */
            ii(0x1011_446f, 1); push(edx);                              /* push edx */
            ii(0x1011_4470, 1); push(esi);                              /* push esi */
            ii(0x1011_4471, 1); push(edi);                              /* push edi */
            ii(0x1011_4472, 1); push(ebp);                              /* push ebp */
            ii(0x1011_4473, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_4475, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1011_447b, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1011_447e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_4481, 5); cmp(memw[ds, eax + 0xc], 0);            /* cmp word [eax+0xc], 0x0 */
            ii(0x1011_4486, 2); if(jz(0x1011_449d, 0x15)) goto l_0x1011_449d; /* jz 0x1011449d */
            ii(0x1011_4488, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1011_448a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_448d, 3); mov(edx, memd[ds, eax + 0x12]);         /* mov edx, [eax+0x12] */
            ii(0x1011_4490, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_4493, 5); mov(eax, 0x1f);                         /* mov eax, 0x1f */
            ii(0x1011_4498, 5); call(0x1012_aad5, 0x1_6638);            /* call 0x1012aad5 */
        l_0x1011_449d:
            ii(0x1011_449d, 7); mov(memb[ds, 0x101c_391e], 0x3);        /* mov byte [0x101c391e], 0x3 */
            ii(0x1011_44a4, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_44a7, 7); mov(memd[ds, eax + 0x4], 0x1b);         /* mov dword [eax+0x4], 0x1b */
            ii(0x1011_44ae, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_44b0, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_44b1, 1); pop(edi);                               /* pop edi */
            ii(0x1011_44b2, 1); pop(esi);                               /* pop esi */
            ii(0x1011_44b3, 1); pop(edx);                               /* pop edx */
            ii(0x1011_44b4, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_44b5, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_44b6, 1); ret();                                  /* ret */
        }
    }
}
