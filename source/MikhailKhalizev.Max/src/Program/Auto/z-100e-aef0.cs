using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_aef0-5d6ffa36")]
        public void Method_100e_aef0()
        {
            ii(0x100e_aef0, 5); push(0x24);                             /* push 0x24 */
            ii(0x100e_aef5, 5); call(Definitions.sys_check_available_stack_size, 0x7_ae58); /* call 0x10165d52 */
            ii(0x100e_aefa, 1); push(ebx);                              /* push ebx */
            ii(0x100e_aefb, 1); push(ecx);                              /* push ecx */
            ii(0x100e_aefc, 1); push(edx);                              /* push edx */
            ii(0x100e_aefd, 1); push(esi);                              /* push esi */
            ii(0x100e_aefe, 1); push(edi);                              /* push edi */
            ii(0x100e_aeff, 1); push(ebp);                              /* push ebp */
            ii(0x100e_af00, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_af02, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100e_af08, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100e_af0b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_af0e, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100e_af10, 5); call(Definitions.my_strobj_get_len, 0xf); /* call 0x100eaf24 */
            ii(0x100e_af15, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100e_af18, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_af1b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_af1d, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_af1e, 1); pop(edi);                               /* pop edi */
            ii(0x100e_af1f, 1); pop(esi);                               /* pop esi */
            ii(0x100e_af20, 1); pop(edx);                               /* pop edx */
            ii(0x100e_af21, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_af22, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_af23, 1); ret();                                  /* ret */
        }
    }
}
