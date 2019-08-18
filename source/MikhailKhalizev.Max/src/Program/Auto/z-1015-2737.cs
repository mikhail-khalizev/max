using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e9b5a83b-f597-481d-8885-7c41f80b3d2d")]
        public void Method_1015_2737()
        {
            ii(0x1015_2737, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1015_273c, 5); calld(Definitions.sys_check_available_stack_size, 0x1_3611); /* call 0x10165d52 */
            ii(0x1015_2741, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_2742, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_2743, 1); pushd(esi);                             /* push esi */
            ii(0x1015_2744, 1); pushd(edi);                             /* push edi */
            ii(0x1015_2745, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_2746, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_2748, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1015_274e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_2751, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1015_2754, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_2757, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_275a, 5); add(eax, 0x8a);                         /* add eax, 0x8a */
            ii(0x1015_275f, 5); calld(0x1015_5204, 0x2aa0);             /* call 0x10155204 */
            ii(0x1015_2764, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_2766, 2); if(jzd(0x1015_276e, 0x6)) goto l_0x1015_276e; /* jz 0x1015276e */
            ii(0x1015_2768, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1015_276c, 2); jmpd(0x1015_2772, 0x4); goto l_0x1015_2772; /* jmp 0x10152772 */
        l_0x1015_276e:
            ii(0x1015_276e, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
        l_0x1015_2772:
            ii(0x1015_2772, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1015_2775, 3); mov(memb_a32[ss, ebp - 0x10], al);      /* mov [ebp-0x10], al */
            ii(0x1015_2778, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x1015_277b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_277d, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_277e, 1); popd(edi);                              /* pop edi */
            ii(0x1015_277f, 1); popd(esi);                              /* pop esi */
            ii(0x1015_2780, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_2781, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_2782, 1); retd(); return;                         /* ret */
        }
    }
}
