using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_0149-87d6faba")]
        public void Method_100d_0149()
        {
            ii(0x100d_0149, 5); push(0x24);                             /* push 0x24 */
            ii(0x100d_014e, 5); call(Definitions.sys_check_available_stack_size, 0x9_5bff); /* call 0x10165d52 */
            ii(0x100d_0153, 1); push(ebx);                              /* push ebx */
            ii(0x100d_0154, 1); push(ecx);                              /* push ecx */
            ii(0x100d_0155, 1); push(edx);                              /* push edx */
            ii(0x100d_0156, 1); push(esi);                              /* push esi */
            ii(0x100d_0157, 1); push(edi);                              /* push edi */
            ii(0x100d_0158, 1); push(ebp);                              /* push ebp */
            ii(0x100d_0159, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_015b, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100d_0161, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100d_0164, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_0167, 3); add(eax, 0x1e);                         /* add eax, 0x1e */
            ii(0x100d_016a, 5); call(Definitions.my_2_get_count, -0x4_4e07); /* call 0x1008b368 */
            ii(0x100d_016f, 1); cwde();                                 /* cwde */
            ii(0x100d_0170, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_0172, 2); if(jnz(0x100d_017d, 9)) goto l_0x100d_017d; /* jnz 0x100d017d */
            ii(0x100d_0174, 7); mov(memd[ss, ebp - 8], 0xffff_ffff);    /* mov dword [ebp-0x8], 0xffffffff */
            ii(0x100d_017b, 2); jmp(0x100d_0197, 0x1a); goto l_0x100d_0197; /* jmp 0x100d0197 */
        l_0x100d_017d:
            ii(0x100d_017d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_0180, 3); mov(edx, memd[ds, eax + 0x24]);         /* mov edx, [eax+0x24] */
            ii(0x100d_0183, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_0186, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_0189, 3); add(eax, 0x1e);                         /* add eax, 0x1e */
            ii(0x100d_018c, 5); call(0x1008_b228, -0x4_4f69);           /* call 0x1008b228 */
            ii(0x100d_0191, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x100d_0194, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
        l_0x100d_0197:
            ii(0x100d_0197, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_019a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_019c, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_019d, 1); pop(edi);                               /* pop edi */
            ii(0x100d_019e, 1); pop(esi);                               /* pop esi */
            ii(0x100d_019f, 1); pop(edx);                               /* pop edx */
            ii(0x100d_01a0, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_01a1, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_01a2, 1); ret();                                  /* ret */
        }
    }
}
