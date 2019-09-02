using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_f48f-7605e6f0")]
        public void my_fread()
        {
            ii(0x100e_f48f, 5); push(0x24);                             /* push 0x24 */
            ii(0x100e_f494, 5); call(Definitions.sys_check_available_stack_size, 0x7_68b9); /* call 0x10165d52 */
            ii(0x100e_f499, 1); push(esi);                              /* push esi */
            ii(0x100e_f49a, 1); push(edi);                              /* push edi */
            ii(0x100e_f49b, 1); push(ebp);                              /* push ebp */
            ii(0x100e_f49c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_f49e, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100e_f4a4, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x100e_f4a7, 3); mov(memd[ss, ebp - 12], edx);           /* mov [ebp-0xc], edx */
            ii(0x100e_f4aa, 3); mov(memd[ss, ebp - 8], ebx);            /* mov [ebp-0x8], ebx */
            ii(0x100e_f4ad, 3); mov(memd[ss, ebp - 4], ecx);            /* mov [ebp-0x4], ecx */
            ii(0x100e_f4b0, 3); mov(ecx, memd[ss, ebp - 4]);            /* mov ecx, [ebp-0x4] */
            ii(0x100e_f4b3, 3); mov(ebx, memd[ss, ebp - 8]);            /* mov ebx, [ebp-0x8] */
            ii(0x100e_f4b6, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x100e_f4b9, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100e_f4bc, 5); call(Definitions.sys_fread, 0x8_30ab);  /* call 0x1017256c */
            ii(0x100e_f4c1, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x100e_f4c4, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100e_f4c7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_f4c9, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_f4ca, 1); pop(edi);                               /* pop edi */
            ii(0x100e_f4cb, 1); pop(esi);                               /* pop esi */
            ii(0x100e_f4cc, 1); ret();                                  /* ret */
        }
    }
}
