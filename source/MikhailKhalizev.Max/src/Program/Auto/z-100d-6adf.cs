using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_6adf-4b29fc94")]
        public void Method_100d_6adf()
        {
            ii(0x100d_6adf, 5); push(0x4c);                             /* push 0x4c */
            ii(0x100d_6ae4, 5); call(Definitions.sys_check_available_stack_size, 0x8_f269); /* call 0x10165d52 */
            ii(0x100d_6ae9, 1); push(ebx);                              /* push ebx */
            ii(0x100d_6aea, 1); push(ecx);                              /* push ecx */
            ii(0x100d_6aeb, 1); push(esi);                              /* push esi */
            ii(0x100d_6aec, 1); push(edi);                              /* push edi */
            ii(0x100d_6aed, 1); push(ebp);                              /* push ebp */
            ii(0x100d_6aee, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_6af0, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x100d_6af6, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100d_6af9, 3); mov(memb[ss, ebp - 4], dl);             /* mov [ebp-0x4], dl */
            ii(0x100d_6afc, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_6aff, 3); cmp(memd[ds, eax], 0);                  /* cmp dword [eax], 0x0 */
            ii(0x100d_6b02, 2); if(jnz(0x100d_6b0d, 9)) goto l_0x100d_6b0d; /* jnz 0x100d6b0d */
            ii(0x100d_6b04, 7); mov(memd[ss, ebp - 12], 0);             /* mov dword [ebp-0xc], 0x0 */
            ii(0x100d_6b0b, 2); jmp(0x100d_6b26, 0x19); goto l_0x100d_6b26; /* jmp 0x100d6b26 */
        l_0x100d_6b0d:
            ii(0x100d_6b0d, 5); mov(ecx, 0x9a);                         /* mov ecx, 0x9a */
            ii(0x100d_6b12, 5); mov(ebx, StringDefinitions.CommoCpp2);  /* mov ebx, 0x101a17d8 */
            ii(0x100d_6b17, 5); mov(edx, StringDefinitions.WindowIdEqual0); /* mov edx, 0x101a17e2 */
            ii(0x100d_6b1c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100d_6b1e, 5); call(Definitions.sys_assert, 0x8_f26f); /* call 0x10165d92 */
            ii(0x100d_6b23, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
        l_0x100d_6b26:
            ii(0x100d_6b26, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_6b29, 3); push(memd[ds, eax + 12]);               /* push dword [eax+0xc] */
            ii(0x100d_6b2c, 2); push(0);                                /* push 0x0 */
            ii(0x100d_6b2e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_6b31, 3); mov(ecx, memd[ds, eax + 8]);            /* mov ecx, [eax+0x8] */
            ii(0x100d_6b34, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100d_6b37, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_6b3a, 3); mov(ebx, memd[ds, eax + 6]);            /* mov ebx, [eax+0x6] */
            ii(0x100d_6b3d, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100d_6b40, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_6b43, 3); mov(edx, memd[ds, eax + 4]);            /* mov edx, [eax+0x4] */
            ii(0x100d_6b46, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_6b49, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_6b4c, 3); mov(eax, memd[ds, eax + 2]);            /* mov eax, [eax+0x2] */
            ii(0x100d_6b4f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_6b52, 5); call(/* sys */ 0x1016_6764, 0x8_fc0d);  /* call 0x10166764 */
            ii(0x100d_6b57, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_6b59, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_6b5c, 2); mov(memd[ds, eax], edx);                /* mov [eax], edx */
            ii(0x100d_6b5e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_6b61, 3); mov(eax, memd[ds, eax + 14]);           /* mov eax, [eax+0xe] */
            ii(0x100d_6b64, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_6b67, 3); cmp(eax, -1 /* 0xff */);                /* cmp eax, 0xffffffff */
            ii(0x100d_6b6a, 2); if(jz(0x100d_6bb0, 0x44)) goto l_0x100d_6bb0; /* jz 0x100d6bb0 */
            ii(0x100d_6b6c, 3); lea(edx, memd[ss, ebp - 40]);           /* lea edx, [ebp-0x28] */
            ii(0x100d_6b6f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_6b72, 5); call(0x100d_6a11, -0x166);              /* call 0x100d6a11 */
            ii(0x100d_6b77, 5); call(0x100d_533c, -0x1840);             /* call 0x100d533c */
            ii(0x100d_6b7c, 1); cwde();                                 /* cwde */
            ii(0x100d_6b7d, 1); push(eax);                              /* push eax */
            ii(0x100d_6b7e, 5); call(0x100d_5360, -0x1823);             /* call 0x100d5360 */
            ii(0x100d_6b83, 1); cwde();                                 /* cwde */
            ii(0x100d_6b84, 1); push(eax);                              /* push eax */
            ii(0x100d_6b85, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100d_6b87, 3); mov(al, memb[ss, ebp - 4]);             /* mov al, [ebp-0x4] */
            ii(0x100d_6b8a, 1); push(eax);                              /* push eax */
            ii(0x100d_6b8b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_6b8e, 3); mov(al, memb[ds, eax + 18]);            /* mov al, [eax+0x12] */
            ii(0x100d_6b91, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x100d_6b93, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100d_6b96, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_6b99, 3); mov(ebx, memd[ds, eax + 6]);            /* mov ebx, [eax+0x6] */
            ii(0x100d_6b9c, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100d_6b9f, 3); lea(edx, memd[ss, ebp - 40]);           /* lea edx, [ebp-0x28] */
            ii(0x100d_6ba2, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_6ba5, 3); mov(eax, memd[ds, eax + 14]);           /* mov eax, [eax+0xe] */
            ii(0x100d_6ba8, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_6bab, 5); call(0x100e_8c51, 0x1_20a1);            /* call 0x100e8c51 */
        l_0x100d_6bb0:
            ii(0x100d_6bb0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_6bb2, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_6bb3, 1); pop(edi);                               /* pop edi */
            ii(0x100d_6bb4, 1); pop(esi);                               /* pop esi */
            ii(0x100d_6bb5, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_6bb6, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_6bb7, 1); ret();                                  /* ret */
        }
    }
}
