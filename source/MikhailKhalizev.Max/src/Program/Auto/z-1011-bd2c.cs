using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_bd2c-9aa7cf39")]
        public void Method_1011_bd2c()
        {
            ii(0x1011_bd2c, 5); push(0x20);                             /* push 0x20 */
            ii(0x1011_bd31, 5); call(Definitions.sys_check_available_stack_size, 0x4_a01c); /* call 0x10165d52 */
            ii(0x1011_bd36, 1); push(ebx);                              /* push ebx */
            ii(0x1011_bd37, 1); push(ecx);                              /* push ecx */
            ii(0x1011_bd38, 1); push(esi);                              /* push esi */
            ii(0x1011_bd39, 1); push(edi);                              /* push edi */
            ii(0x1011_bd3a, 1); push(ebp);                              /* push ebp */
            ii(0x1011_bd3b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_bd3d, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1011_bd43, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1011_bd46, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1011_bd49, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_bd4c, 3); mov(ebx, memd[ds, eax + 0x14]);         /* mov ebx, [eax+0x14] */
            ii(0x1011_bd4f, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1011_bd52, 5); mov(edx, StringDefinitions.X8);         /* mov edx, 0x101a7d9a */
            ii(0x1011_bd57, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_bd5a, 5); call(0x1014_74f5, 0x2_b796);            /* call 0x101474f5 */
            ii(0x1011_bd5f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_bd62, 3); mov(ebx, memd[ds, eax + 0x16]);         /* mov ebx, [eax+0x16] */
            ii(0x1011_bd65, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1011_bd68, 5); mov(edx, StringDefinitions.Y6);         /* mov edx, 0x101a7d9c */
            ii(0x1011_bd6d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_bd70, 5); call(0x1014_74f5, 0x2_b780);            /* call 0x101474f5 */
            ii(0x1011_bd75, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_bd77, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_bd78, 1); pop(edi);                               /* pop edi */
            ii(0x1011_bd79, 1); pop(esi);                               /* pop esi */
            ii(0x1011_bd7a, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_bd7b, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_bd7c, 1); ret();                                  /* ret */
        }
    }
}
