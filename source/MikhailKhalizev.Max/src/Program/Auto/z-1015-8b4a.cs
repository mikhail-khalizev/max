using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_8b4a-c1f4f447")]
        public void Method_1015_8b4a()
        {
            ii(0x1015_8b4a, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1015_8b4f, 5); calld(Definitions.sys_check_available_stack_size, 0xd1fe); /* call 0x10165d52 */
            ii(0x1015_8b54, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_8b55, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_8b56, 1); pushd(esi);                             /* push esi */
            ii(0x1015_8b57, 1); pushd(edi);                             /* push edi */
            ii(0x1015_8b58, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_8b59, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_8b5b, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1015_8b61, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_8b64, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1015_8b67, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_8b6a, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1015_8b6d, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_8b72, 5); calld(0x100f_448c, -0x6_46eb);          /* call 0x100f448c */
            ii(0x1015_8b77, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_8b7a, 4); cmp(memb_a32[ds, eax + 0x5b], 0);       /* cmp byte [eax+0x5b], 0x0 */
            ii(0x1015_8b7e, 2); if(jnzd(0x1015_8b86, 0x6)) goto l_0x1015_8b86; /* jnz 0x10158b86 */
            ii(0x1015_8b80, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1015_8b84, 2); jmpd(0x1015_8b8a, 0x4); goto l_0x1015_8b8a; /* jmp 0x10158b8a */
        l_0x1015_8b86:
            ii(0x1015_8b86, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
        l_0x1015_8b8a:
            ii(0x1015_8b8a, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1015_8b8d, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1015_8b90, 3); mov(memb_a32[ds, edx + 0x5b], al);      /* mov [edx+0x5b], al */
            ii(0x1015_8b93, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_8b96, 4); cmp(memb_a32[ds, eax + 0x3d], 0xc);     /* cmp byte [eax+0x3d], 0xc */
            ii(0x1015_8b9a, 2); if(jnzd(0x1015_8bab, 0xf)) goto l_0x1015_8bab; /* jnz 0x10158bab */
            ii(0x1015_8b9c, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1015_8ba1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_8ba3, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_8ba6, 5); calld(0x1016_3053, 0xa4a8);             /* call 0x10163053 */
        l_0x1015_8bab:
            ii(0x1015_8bab, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_8bae, 5); calld(0x1010_094d, -0x5_8266);          /* call 0x1010094d */
            ii(0x1015_8bb3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_8bb5, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_8bb6, 1); popd(edi);                              /* pop edi */
            ii(0x1015_8bb7, 1); popd(esi);                              /* pop esi */
            ii(0x1015_8bb8, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_8bb9, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_8bba, 1); retd();                                 /* ret */
        }
    }
}
