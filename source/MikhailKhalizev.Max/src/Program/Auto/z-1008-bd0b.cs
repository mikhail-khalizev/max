using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_bd0b-49061661")]
        public void Method_1008_bd0b()
        {
            ii(0x1008_bd0b, 5); push(0x28);                             /* push 0x28 */
            ii(0x1008_bd10, 5); call(Definitions.sys_check_available_stack_size, 0xd_a03d); /* call 0x10165d52 */
            ii(0x1008_bd15, 1); push(esi);                              /* push esi */
            ii(0x1008_bd16, 1); push(edi);                              /* push edi */
            ii(0x1008_bd17, 1); push(ebp);                              /* push ebp */
            ii(0x1008_bd18, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_bd1a, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1008_bd20, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1008_bd23, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x1008_bd26, 3); mov(memd[ss, ebp - 8], ebx);            /* mov [ebp-0x8], ebx */
            ii(0x1008_bd29, 3); mov(memd[ss, ebp - 4], ecx);            /* mov [ebp-0x4], ecx */
            ii(0x1008_bd2c, 3); mov(ebx, memd[ss, ebp - 8]);            /* mov ebx, [ebp-0x8] */
            ii(0x1008_bd2f, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1008_bd32, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_bd35, 5); call(0x100a_6bd8, 0x1_ae9e);            /* call 0x100a6bd8 */
            ii(0x1008_bd3a, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1008_bd3d, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_bd40, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1008_bd43, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_bd46, 7); mov(memd[ds, eax + 2], 0x101b_476c);    /* mov dword [eax+0x2], 0x101b476c */
            ii(0x1008_bd4d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_bd50, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1008_bd53, 4); mov(memw[ds, edx + 0x1f], ax);          /* mov [edx+0x1f], ax */
            ii(0x1008_bd57, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_bd5a, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1008_bd5d, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1008_bd60, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_bd62, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_bd63, 1); pop(edi);                               /* pop edi */
            ii(0x1008_bd64, 1); pop(esi);                               /* pop esi */
            ii(0x1008_bd65, 1); ret();                                  /* ret */
        }
    }
}
