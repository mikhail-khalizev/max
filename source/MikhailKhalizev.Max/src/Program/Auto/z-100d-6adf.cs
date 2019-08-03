using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("cc1a2aeb-ba14-4688-ae2f-9b9811056952")]
        public void Method_100d_6adf()
        {
            ii(0x100d_6adf, 5); pushd(0x4c);                            /* push 0x4c */
            ii(0x100d_6ae4, 5); calld(Definitions.sys_check_available_stack_size, 0x8f269); /* call 0x10165d52 */
            ii(0x100d_6ae9, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_6aea, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_6aeb, 1); pushd(esi);                             /* push esi */
            ii(0x100d_6aec, 1); pushd(edi);                             /* push edi */
            ii(0x100d_6aed, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_6aee, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_6af0, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x100d_6af6, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_6af9, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x100d_6afc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_6aff, 3); cmp(memd_a32[ds, eax], 0);              /* cmp dword [eax], 0x0 */
            ii(0x100d_6b02, 2); if(jnzd(0x100d_6b0d, 0x9)) goto l_0x100d_6b0d; /* jnz 0x100d6b0d */
            ii(0x100d_6b04, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x100d_6b0b, 2); jmpd(0x100d_6b26, 0x19); goto l_0x100d_6b26; /* jmp 0x100d6b26 */
        l_0x100d_6b0d:
            ii(0x100d_6b0d, 5); mov(ecx, 0x9a);                         /* mov ecx, 0x9a */
            ii(0x100d_6b12, 5); mov(ebx, 0x101a_17d8);                  /* mov ebx, 0x101a17d8 */ /* "commo.cpp" */
            ii(0x100d_6b17, 5); mov(edx, 0x101a_17e2);                  /* mov edx, 0x101a17e2 */ /* "window_id == 0" */
            ii(0x100d_6b1c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100d_6b1e, 5); calld(Definitions.sys_assert, 0x8f26f); /* call 0x10165d92 */
            ii(0x100d_6b23, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
        l_0x100d_6b26:
            ii(0x100d_6b26, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_6b29, 3); pushd(memd_a32[ds, eax + 0xc]);         /* push dword [eax+0xc] */
            ii(0x100d_6b2c, 2); pushd(0);                               /* push 0x0 */
            ii(0x100d_6b2e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_6b31, 3); mov(ecx, memd_a32[ds, eax + 0x8]);      /* mov ecx, [eax+0x8] */
            ii(0x100d_6b34, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100d_6b37, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_6b3a, 3); mov(ebx, memd_a32[ds, eax + 0x6]);      /* mov ebx, [eax+0x6] */
            ii(0x100d_6b3d, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100d_6b40, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_6b43, 3); mov(edx, memd_a32[ds, eax + 0x4]);      /* mov edx, [eax+0x4] */
            ii(0x100d_6b46, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_6b49, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_6b4c, 3); mov(eax, memd_a32[ds, eax + 0x2]);      /* mov eax, [eax+0x2] */
            ii(0x100d_6b4f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_6b52, 5); calld(/* sys */ 0x1016_6764, 0x8fc0d);  /* call 0x10166764 */
            ii(0x100d_6b57, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_6b59, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_6b5c, 2); mov(memd_a32[ds, eax], edx);            /* mov [eax], edx */
            ii(0x100d_6b5e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_6b61, 3); mov(eax, memd_a32[ds, eax + 0xe]);      /* mov eax, [eax+0xe] */
            ii(0x100d_6b64, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_6b67, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x100d_6b6a, 2); if(jzd(0x100d_6bb0, 0x44)) goto l_0x100d_6bb0; /* jz 0x100d6bb0 */
            ii(0x100d_6b6c, 3); lea(edx, ebp - 0x28);                   /* lea edx, [ebp-0x28] */
            ii(0x100d_6b6f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_6b72, 5); calld(0x100d_6a11, -0x166);             /* call 0x100d6a11 */
            ii(0x100d_6b77, 5); calld(0x100d_533c, -0x1840);            /* call 0x100d533c */
            ii(0x100d_6b7c, 1); cwde();                                 /* cwde */
            ii(0x100d_6b7d, 1); pushd(eax);                             /* push eax */
            ii(0x100d_6b7e, 5); calld(0x100d_5360, -0x1823);            /* call 0x100d5360 */
            ii(0x100d_6b83, 1); cwde();                                 /* cwde */
            ii(0x100d_6b84, 1); pushd(eax);                             /* push eax */
            ii(0x100d_6b85, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100d_6b87, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100d_6b8a, 1); pushd(eax);                             /* push eax */
            ii(0x100d_6b8b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_6b8e, 3); mov(al, memb_a32[ds, eax + 0x12]);      /* mov al, [eax+0x12] */
            ii(0x100d_6b91, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x100d_6b93, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100d_6b96, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_6b99, 3); mov(ebx, memd_a32[ds, eax + 0x6]);      /* mov ebx, [eax+0x6] */
            ii(0x100d_6b9c, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100d_6b9f, 3); lea(edx, ebp - 0x28);                   /* lea edx, [ebp-0x28] */
            ii(0x100d_6ba2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_6ba5, 3); mov(eax, memd_a32[ds, eax + 0xe]);      /* mov eax, [eax+0xe] */
            ii(0x100d_6ba8, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_6bab, 5); calld(0x100e_8c51, 0x120a1);            /* call 0x100e8c51 */
        l_0x100d_6bb0:
            ii(0x100d_6bb0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_6bb2, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_6bb3, 1); popd(edi);                              /* pop edi */
            ii(0x100d_6bb4, 1); popd(esi);                              /* pop esi */
            ii(0x100d_6bb5, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_6bb6, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_6bb7, 1); retd(); return;                         /* ret */
        }
    }
}
