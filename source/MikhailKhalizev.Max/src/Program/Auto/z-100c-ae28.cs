using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_ae28-e8dd56c3")]
        public void Method_100c_ae28()
        {
            ii(0x100c_ae28, 5); push(0x24);                             /* push 0x24 */
            ii(0x100c_ae2d, 5); call(Definitions.sys_check_available_stack_size, 0x9_af20); /* call 0x10165d52 */
            ii(0x100c_ae32, 1); push(ebx);                              /* push ebx */
            ii(0x100c_ae33, 1); push(ecx);                              /* push ecx */
            ii(0x100c_ae34, 1); push(edx);                              /* push edx */
            ii(0x100c_ae35, 1); push(esi);                              /* push esi */
            ii(0x100c_ae36, 1); push(edi);                              /* push edi */
            ii(0x100c_ae37, 1); push(ebp);                              /* push ebp */
            ii(0x100c_ae38, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_ae3a, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100c_ae40, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100c_ae43, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_ae46, 5); call(0x1008_b410, -0x3_fa3b);           /* call 0x1008b410 */
            ii(0x100c_ae4b, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100c_ae4e, 5); call(Definitions.my_3_get_count, -0x3_f9d3); /* call 0x1008b480 */
            ii(0x100c_ae53, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_ae56, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_ae59, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_ae5b, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_ae5c, 1); pop(edi);                               /* pop edi */
            ii(0x100c_ae5d, 1); pop(esi);                               /* pop esi */
            ii(0x100c_ae5e, 1); pop(edx);                               /* pop edx */
            ii(0x100c_ae5f, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_ae60, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_ae61, 1); ret();                                  /* ret */
        }
    }
}
