using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c01b160a-89f7-40a4-aad7-15030bda3921")]
        public void Method_1010_6acf()
        {
            ii(0x1010_6acf, 5); pushd(0x90);                            /* push 0x90 */
            ii(0x1010_6ad4, 5); calld(Definitions.sys_check_available_stack_size, 0x5_f279); /* call 0x10165d52 */
            ii(0x1010_6ad9, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_6ada, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_6adb, 1); pushd(edx);                             /* push edx */
            ii(0x1010_6adc, 1); pushd(esi);                             /* push esi */
            ii(0x1010_6add, 1); pushd(edi);                             /* push edi */
            ii(0x1010_6ade, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_6adf, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_6ae1, 6); sub(esp, 0x74);                         /* sub esp, 0x74 */
            ii(0x1010_6ae7, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x1010_6aee, 5); mov(ebx, 0x1c);                         /* mov ebx, 0x1c */
            ii(0x1010_6af3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_6af5, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1010_6af8, 5); calld(Definitions.sys_memset, 0x5_f2e3); /* call 0x10165de0 */
            ii(0x1010_6afd, 7); mov(memd_a32[ss, ebp - 0x38], 0x400);   /* mov dword [ebp-0x38], 0x400 */
            ii(0x1010_6b04, 3); lea(ebx, ebp - 0x38);                   /* lea ebx, [ebp-0x38] */
            ii(0x1010_6b07, 3); lea(edx, ebp - 0x38);                   /* lea edx, [ebp-0x38] */
            ii(0x1010_6b0a, 5); mov(eax, 0x31);                         /* mov eax, 0x31 */
            ii(0x1010_6b0f, 5); calld(/* sys */ 0x1016_c606, 0x6_5af2); /* call 0x1016c606 */
            ii(0x1010_6b14, 4); cmp(memd_a32[ss, ebp - 0x20], 0);       /* cmp dword [ebp-0x20], 0x0 */
            ii(0x1010_6b18, 2); if(jnzd(0x1010_6b72, 0x58)) goto l_0x1010_6b72; /* jnz 0x10106b72 */
            ii(0x1010_6b1a, 5); mov(ebx, 0x1c);                         /* mov ebx, 0x1c */
            ii(0x1010_6b1f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_6b21, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1010_6b24, 5); calld(Definitions.sys_memset, 0x5_f2b7); /* call 0x10165de0 */
            ii(0x1010_6b29, 5); mov(ebx, 0xc);                          /* mov ebx, 0xc */
            ii(0x1010_6b2e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_6b30, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1010_6b33, 5); calld(Definitions.sys_memset, 0x5_f2a8); /* call 0x10165de0 */
            ii(0x1010_6b38, 7); mov(memd_a32[ss, ebp - 0x38], 0x500);   /* mov dword [ebp-0x38], 0x500 */
            ii(0x1010_6b3f, 2); mov(ebx, ss);                           /* mov ebx, ss */
            ii(0x1010_6b41, 3); lea(edx, ebp - 0x74);                   /* lea edx, [ebp-0x74] */
            ii(0x1010_6b44, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1010_6b46, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1010_6b48, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_6b4a, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1010_6b4c, 4); mov(memw_a32[ss, ebp - 0x44], dx);      /* mov [ebp-0x44], dx */
            ii(0x1010_6b50, 3); lea(eax, ebp - 0x74);                   /* lea eax, [ebp-0x74] */
            ii(0x1010_6b53, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1010_6b56, 3); lea(ecx, ebp - 0x44);                   /* lea ecx, [ebp-0x44] */
            ii(0x1010_6b59, 3); lea(ebx, ebp - 0x38);                   /* lea ebx, [ebp-0x38] */
            ii(0x1010_6b5c, 3); lea(edx, ebp - 0x38);                   /* lea edx, [ebp-0x38] */
            ii(0x1010_6b5f, 5); mov(eax, 0x31);                         /* mov eax, 0x31 */
            ii(0x1010_6b64, 5); calld(/* sys */ 0x1016_c623, 0x6_5aba); /* call 0x1016c623 */
            ii(0x1010_6b69, 3); mov(eax, memd_a32[ss, ebp - 0x64]);     /* mov eax, [ebp-0x64] */
            ii(0x1010_6b6c, 3); shl(eax, 0xc);                          /* shl eax, 0xc */
            ii(0x1010_6b6f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
        l_0x1010_6b72:
            ii(0x1010_6b72, 6); mov(memw_a32[ss, ebp - 0x18], 0);       /* mov word [ebp-0x18], 0x0 */
            ii(0x1010_6b78, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
        l_0x1010_6b7f:
            ii(0x1010_6b7f, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1010_6b82, 5); calld(/* sys */ 0x1017_9185, 0x7_25fe); /* call 0x10179185 */
            ii(0x1010_6b87, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_6b8a, 4); cmp(memd_a32[ss, ebp - 0x4], 0);        /* cmp dword [ebp-0x4], 0x0 */
            ii(0x1010_6b8e, 2); if(jnzd(0x1010_6b9e, 0xe)) goto l_0x1010_6b9e; /* jnz 0x10106b9e */
            ii(0x1010_6b90, 4); cmp(memd_a32[ss, ebp - 0x12], 0x1);     /* cmp dword [ebp-0x12], 0x1 */
            ii(0x1010_6b94, 2); if(jnzd(0x1010_6b9c, 0x6)) goto l_0x1010_6b9c; /* jnz 0x10106b9c */
            ii(0x1010_6b96, 3); mov(eax, memd_a32[ss, ebp - 0x16]);     /* mov eax, [ebp-0x16] */
            ii(0x1010_6b99, 3); add(memd_a32[ss, ebp - 0x8], eax);      /* add [ebp-0x8], eax */
        l_0x1010_6b9c:
            ii(0x1010_6b9c, 2); jmpd(0x1010_6b7f, -0x1f); goto l_0x1010_6b7f; /* jmp 0x10106b7f */
        l_0x1010_6b9e:
            ii(0x1010_6b9e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_6ba1, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1010_6ba4, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_6ba7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_6ba9, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_6baa, 1); popd(edi);                              /* pop edi */
            ii(0x1010_6bab, 1); popd(esi);                              /* pop esi */
            ii(0x1010_6bac, 1); popd(edx);                              /* pop edx */
            ii(0x1010_6bad, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_6bae, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_6baf, 1); retd(); return;                         /* ret */
        }
    }
}
