using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4998453c-26f8-4289-a733-11ed5afc8f92")]
        public void my_play_video_company()
        {
            ii(0x1011_57ff, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1011_5804, 5); calld(Definitions.sys_check_available_stack_size, 0x5_0549); /* call 0x10165d52 */
            ii(0x1011_5809, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_580a, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_580b, 1); pushd(edx);                             /* push edx */
            ii(0x1011_580c, 1); pushd(esi);                             /* push esi */
            ii(0x1011_580d, 1); pushd(edi);                             /* push edi */
            ii(0x1011_580e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_580f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_5811, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1011_5817, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1011_581c, 5); mov(eax, 0x6b4);                        /* mov eax, 0x6b4 */
            ii(0x1011_5821, 5); calld(0x1011_556b, -0x2bb);             /* call 0x1011556b */
            ii(0x1011_5826, 2); test(al, al);                           /* test al, al */
            ii(0x1011_5828, 2); if(jnzd(0x1011_5833, 0x9)) goto l_0x1011_5833; /* jnz 0x10115833 */
            ii(0x1011_582a, 7); mov(memd_a32[ss, ebp - 0x4], 0x1);      /* mov dword [ebp-0x4], 0x1 */
            ii(0x1011_5831, 2); jmpd(0x1011_583a, 0x7); goto l_0x1011_583a; /* jmp 0x1011583a */
        l_0x1011_5833:
            ii(0x1011_5833, 7); mov(memd_a32[ss, ebp - 0x4], 0);        /* mov dword [ebp-0x4], 0x0 */
        l_0x1011_583a:
            ii(0x1011_583a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_583d, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_5840, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_5843, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_5845, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_5846, 1); popd(edi);                              /* pop edi */
            ii(0x1011_5847, 1); popd(esi);                              /* pop esi */
            ii(0x1011_5848, 1); popd(edx);                              /* pop edx */
            ii(0x1011_5849, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_584a, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_584b, 1); retd(); return;                         /* ret */
        }
    }
}
