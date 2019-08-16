using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1be5830c-03d8-46f3-be9c-567897860eba")]
        public void Method_1008_3322()
        {
            ii(0x1008_3322, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1008_3327, 5); calld(Definitions.sys_check_available_stack_size, 0xe_2a26); /* call 0x10165d52 */
            ii(0x1008_332c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_332d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_332e, 1); pushd(edx);                             /* push edx */
            ii(0x1008_332f, 1); pushd(esi);                             /* push esi */
            ii(0x1008_3330, 1); pushd(edi);                             /* push edi */
            ii(0x1008_3331, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_3332, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_3334, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_333a, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_333d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_3340, 3); add(eax, 0x16);                         /* add eax, 0x16 */
            ii(0x1008_3343, 5); calld(0x1007_6b90, -0xc7b8);            /* call 0x10076b90 */
            ii(0x1008_3348, 1); cwde();                                 /* cwde */
            ii(0x1008_3349, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_334b, 2); if(jled(0x1008_3353, 0x6)) goto l_0x1008_3353; /* jle 0x10083353 */
            ii(0x1008_334d, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x1008_3351, 2); jmpd(0x1008_3357, 0x4); goto l_0x1008_3357; /* jmp 0x10083357 */
        l_0x1008_3353:
            ii(0x1008_3353, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
        l_0x1008_3357:
            ii(0x1008_3357, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1008_335a, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x1008_335d, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1008_3360, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_3362, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_3363, 1); popd(edi);                              /* pop edi */
            ii(0x1008_3364, 1); popd(esi);                              /* pop esi */
            ii(0x1008_3365, 1); popd(edx);                              /* pop edx */
            ii(0x1008_3366, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_3367, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_3368, 1); retd(); return;                         /* ret */
        }
    }
}