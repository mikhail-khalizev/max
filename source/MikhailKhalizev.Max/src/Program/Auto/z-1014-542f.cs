using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_542f-36e13475")]
        public void Method_1014_542f()
        {
            ii(0x1014_542f, 5); push(0x2c);                             /* push 0x2c */
            ii(0x1014_5434, 5); call(Definitions.sys_check_available_stack_size, 0x2_0919); /* call 0x10165d52 */
            ii(0x1014_5439, 1); push(esi);                              /* push esi */
            ii(0x1014_543a, 1); push(edi);                              /* push edi */
            ii(0x1014_543b, 1); push(ebp);                              /* push ebp */
            ii(0x1014_543c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_543e, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1014_5444, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1014_5447, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x1014_544a, 3); mov(memd[ss, ebp - 8], ebx);            /* mov [ebp-0x8], ebx */
            ii(0x1014_544d, 3); mov(memd[ss, ebp - 4], ecx);            /* mov [ebp-0x4], ecx */
            ii(0x1014_5450, 3); mov(ebx, memd[ss, ebp - 8]);            /* mov ebx, [ebp-0x8] */
            ii(0x1014_5453, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1014_5456, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_5459, 5); call(0x1014_4f3c, -0x522);              /* call 0x10144f3c */
            ii(0x1014_545e, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1014_5461, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1014_5464, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1014_5467, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_546a, 3); add(eax, 0x14);                         /* add eax, 0x14 */
            ii(0x1014_546d, 5); call(Definitions.my_string_ctor, -0x398a); /* call 0x10141ae8 */
            ii(0x1014_5472, 3); sub(eax, 0x14);                         /* sub eax, 0x14 */
            ii(0x1014_5475, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1014_5478, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1014_547b, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1014_547e, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_5481, 7); mov(memd[ds, eax + 2], 0x101b_7244);    /* mov dword [eax+0x2], 0x101b7244 */
            ii(0x1014_5488, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1014_548b, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_548e, 3); add(eax, 0x14);                         /* add eax, 0x14 */
            ii(0x1014_5491, 5); call(0x1014_2246, -0x3250);             /* call 0x10142246 */
            ii(0x1014_5496, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_5499, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1014_549c, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1014_549f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_54a1, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_54a2, 1); pop(edi);                               /* pop edi */
            ii(0x1014_54a3, 1); pop(esi);                               /* pop esi */
            ii(0x1014_54a4, 1); ret();                                  /* ret */
        }
    }
}
