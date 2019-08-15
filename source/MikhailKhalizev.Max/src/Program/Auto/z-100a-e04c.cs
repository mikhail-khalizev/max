using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("98dc6bb6-fd6e-422a-8979-18e6e8e5df3d")]
        public void Method_100a_e04c()
        {
            ii(0x100a_e04c, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100a_e051, 5); calld(Definitions.sys_check_available_stack_size, 0xb_7cfc); /* call 0x10165d52 */
            ii(0x100a_e056, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_e057, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_e058, 1); pushd(edx);                             /* push edx */
            ii(0x100a_e059, 1); pushd(esi);                             /* push esi */
            ii(0x100a_e05a, 1); pushd(edi);                             /* push edi */
            ii(0x100a_e05b, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_e05c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_e05e, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100a_e064, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_e067, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_e06a, 4); cmp(memb_a32[ds, eax + 0x46], 0);       /* cmp byte [eax+0x46], 0x0 */
            ii(0x100a_e06e, 2); if(jzd(0x100a_e07c, 0xc)) goto l_0x100a_e07c; /* jz 0x100ae07c */
            ii(0x100a_e070, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_e072, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_e075, 5); calld(0x100a_d02d, -0x104d);            /* call 0x100ad02d */
            ii(0x100a_e07a, 2); jmpd(0x100a_e0c3, 0x47); goto l_0x100a_e0c3; /* jmp 0x100ae0c3 */
        l_0x100a_e07c:
            ii(0x100a_e07c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_e07f, 4); cmp(memb_a32[ds, eax + 0x47], 0);       /* cmp byte [eax+0x47], 0x0 */
            ii(0x100a_e083, 2); if(jnzd(0x100a_e094, 0xf)) goto l_0x100a_e094; /* jnz 0x100ae094 */
            ii(0x100a_e085, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x100a_e08a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_e08d, 5); calld(0x100a_d02d, -0x1065);            /* call 0x100ad02d */
            ii(0x100a_e092, 2); jmpd(0x100a_e0c3, 0x2f); goto l_0x100a_e0c3; /* jmp 0x100ae0c3 */
        l_0x100a_e094:
            ii(0x100a_e094, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_e097, 3); add(eax, 0x2c);                         /* add eax, 0x2c */
            ii(0x100a_e09a, 5); calld(0x1009_cb94, -0x1_150b);          /* call 0x1009cb94 */
            ii(0x100a_e09f, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_e0a2, 3); add(edx, 0x22);                         /* add edx, 0x22 */
            ii(0x100a_e0a5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_e0a8, 3); add(eax, 0x1e);                         /* add eax, 0x1e */
            ii(0x100a_e0ab, 5); calld(0x1008_8b44, -0x2_556c);          /* call 0x10088b44 */
            ii(0x100a_e0b0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_e0b3, 6); mov(memw_a32[ds, eax + 0x26], 0xffff);  /* mov word [eax+0x26], 0xffff */
            ii(0x100a_e0b9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_e0bb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_e0be, 5); calld(0x100a_cbbb, -0x1508);            /* call 0x100acbbb */
        l_0x100a_e0c3:
            ii(0x100a_e0c3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_e0c5, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_e0c6, 1); popd(edi);                              /* pop edi */
            ii(0x100a_e0c7, 1); popd(esi);                              /* pop esi */
            ii(0x100a_e0c8, 1); popd(edx);                              /* pop edx */
            ii(0x100a_e0c9, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_e0ca, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_e0cb, 1); retd(); return;                         /* ret */
        }
    }
}
