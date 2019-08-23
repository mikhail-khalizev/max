using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_c802-8e6787e1")]
        public void Method_1015_c802()
        {
            ii(0x1015_c802, 5); push(0x20);                             /* push 0x20 */
            ii(0x1015_c807, 5); call(Definitions.sys_check_available_stack_size, 0x9546); /* call 0x10165d52 */
            ii(0x1015_c80c, 1); push(ebx);                              /* push ebx */
            ii(0x1015_c80d, 1); push(ecx);                              /* push ecx */
            ii(0x1015_c80e, 1); push(edx);                              /* push edx */
            ii(0x1015_c80f, 1); push(esi);                              /* push esi */
            ii(0x1015_c810, 1); push(edi);                              /* push edi */
            ii(0x1015_c811, 1); push(ebp);                              /* push ebp */
            ii(0x1015_c812, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_c814, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1015_c81a, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1015_c81d, 5); mov(eax, 0x3);                          /* mov eax, 0x3 */
            ii(0x1015_c822, 5); call(0x1007_5fdc, -0xe_684b);           /* call 0x10075fdc */
            ii(0x1015_c827, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_c829, 2); if(jnz(0x1015_c84f, 0x24)) goto l_0x1015_c84f; /* jnz 0x1015c84f */
            ii(0x1015_c82b, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1015_c82e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_c831, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1015_c834, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_c839, 3); imul(ebx, eax, 0xa);                    /* imul ebx, eax, 0xa */
            ii(0x1015_c83c, 5); mov(eax, 0x101c_9480);                  /* mov eax, 0x101c9480 */
            ii(0x1015_c841, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1015_c843, 5); call(0x1008_ab1c, -0xd_1d2c);           /* call 0x1008ab1c */
            ii(0x1015_c848, 7); mov(memb[ds, 0x101c_8170], 0x1);        /* mov byte [0x101c8170], 0x1 */
        l_0x1015_c84f:
            ii(0x1015_c84f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_c851, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_c852, 1); pop(edi);                               /* pop edi */
            ii(0x1015_c853, 1); pop(esi);                               /* pop esi */
            ii(0x1015_c854, 1); pop(edx);                               /* pop edx */
            ii(0x1015_c855, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_c856, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_c857, 1); ret();                                  /* ret */
        }
    }
}
