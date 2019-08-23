using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_a542-c25f9dc4")]
        public void Method_1009_a542()
        {
            ii(0x1009_a542, 5); push(0x20);                             /* push 0x20 */
            ii(0x1009_a547, 5); call(Definitions.sys_check_available_stack_size, 0xc_b806); /* call 0x10165d52 */
            ii(0x1009_a54c, 1); push(ecx);                              /* push ecx */
            ii(0x1009_a54d, 1); push(esi);                              /* push esi */
            ii(0x1009_a54e, 1); push(edi);                              /* push edi */
            ii(0x1009_a54f, 1); push(ebp);                              /* push ebp */
            ii(0x1009_a550, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_a552, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_a558, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1009_a55b, 3); mov(memd[ss, ebp - 0x8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1009_a55e, 3); mov(memb[ss, ebp - 0x4], bl);           /* mov [ebp-0x4], bl */
            ii(0x1009_a561, 4); cmp(memb[ss, ebp - 0x4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1009_a565, 2); if(jnz(0x1009_a578, 0x11)) goto l_0x1009_a578; /* jnz 0x1009a578 */
            ii(0x1009_a567, 5); call(0x1008_b0e4, -0xf488);             /* call 0x1008b0e4 */
            ii(0x1009_a56c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_a56e, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1009_a570, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_a573, 5); call(0x100a_297d, 0x8405);              /* call 0x100a297d */
        l_0x1009_a578:
            ii(0x1009_a578, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_a57a, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_a57b, 1); pop(edi);                               /* pop edi */
            ii(0x1009_a57c, 1); pop(esi);                               /* pop esi */
            ii(0x1009_a57d, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_a57e, 1); ret();                                  /* ret */
        }
    }
}
