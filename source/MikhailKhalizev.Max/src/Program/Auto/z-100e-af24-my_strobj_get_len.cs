using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_af24-689a3d4d")]
        public void my_strobj_get_len()
        {
            ii(0x100e_af24, 5); push(0x24);                             /* push 0x24 */
            ii(0x100e_af29, 5); call(Definitions.sys_check_available_stack_size, 0x7_ae24); /* call 0x10165d52 */
            ii(0x100e_af2e, 1); push(ebx);                              /* push ebx */
            ii(0x100e_af2f, 1); push(ecx);                              /* push ecx */
            ii(0x100e_af30, 1); push(edx);                              /* push edx */
            ii(0x100e_af31, 1); push(esi);                              /* push esi */
            ii(0x100e_af32, 1); push(edi);                              /* push edi */
            ii(0x100e_af33, 1); push(ebp);                              /* push ebp */
            ii(0x100e_af34, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_af36, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100e_af3c, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100e_af3f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_af42, 4); mov(ax, memw[ds, eax + 6]);             /* mov ax, [eax+0x6] */
            ii(0x100e_af46, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100e_af49, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_af4c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_af4e, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_af4f, 1); pop(edi);                               /* pop edi */
            ii(0x100e_af50, 1); pop(esi);                               /* pop esi */
            ii(0x100e_af51, 1); pop(edx);                               /* pop edx */
            ii(0x100e_af52, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_af53, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_af54, 1); ret();                                  /* ret */
        }
    }
}
