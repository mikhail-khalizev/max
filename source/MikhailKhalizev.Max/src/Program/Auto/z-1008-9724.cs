using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_9724-8ef26a4c")]
        public void Method_1008_9724()
        {
            ii(0x1008_9724, 5); push(0x28);                             /* push 0x28 */
            ii(0x1008_9729, 5); call(Definitions.sys_check_available_stack_size, 0xd_c624); /* call 0x10165d52 */
            ii(0x1008_972e, 1); push(ebx);                              /* push ebx */
            ii(0x1008_972f, 1); push(ecx);                              /* push ecx */
            ii(0x1008_9730, 1); push(edx);                              /* push edx */
            ii(0x1008_9731, 1); push(esi);                              /* push esi */
            ii(0x1008_9732, 1); push(edi);                              /* push edi */
            ii(0x1008_9733, 1); push(ebp);                              /* push ebp */
            ii(0x1008_9734, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_9736, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_973c, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_973f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_9742, 5); call(Definitions.my_ctor_0x101b_6edc, -0x1_2903); /* call 0x10076e44 */
            ii(0x1008_9747, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_974a, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1008_974d, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_9750, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_9753, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1008_9756, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_9759, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_975b, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_975c, 1); pop(edi);                               /* pop edi */
            ii(0x1008_975d, 1); pop(esi);                               /* pop esi */
            ii(0x1008_975e, 1); pop(edx);                               /* pop edx */
            ii(0x1008_975f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_9760, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_9761, 1); ret();                                  /* ret */
        }
    }
}
