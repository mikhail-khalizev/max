using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2a8cf909-1c23-4569-bb8c-d764d3ebf370")]
        public void Method_1009_94bc()
        {
            ii(0x1009_94bc, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x1009_94c1, 5); calld(Definitions.sys_check_available_stack_size, 0xc_c88c); /* call 0x10165d52 */
            ii(0x1009_94c6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_94c7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_94c8, 1); pushd(edx);                             /* push edx */
            ii(0x1009_94c9, 1); pushd(esi);                             /* push esi */
            ii(0x1009_94ca, 1); pushd(edi);                             /* push edi */
            ii(0x1009_94cb, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_94cc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_94ce, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1009_94d4, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_94d7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_94da, 4); cmp(memb_a32[ds, eax + 0x1d], 0);       /* cmp byte [eax+0x1d], 0x0 */
            ii(0x1009_94de, 6); if(jnzd(0x1009_956d, 0x89)) goto l_0x1009_956d; /* jnz 0x1009956d */
            ii(0x1009_94e4, 5); mov(eax, 0x1d);                         /* mov eax, 0x1d */
            ii(0x1009_94e9, 5); calld(Definitions.sys_new, 0xc_c912);   /* call 0x10165e00 */
            ii(0x1009_94ee, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_94f1, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_94f4, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1009_94f7, 4); cmp(memd_a32[ss, ebp - 0x10], 0);       /* cmp dword [ebp-0x10], 0x0 */
            ii(0x1009_94fb, 2); if(jzd(0x1009_9519, 0x1c)) goto l_0x1009_9519; /* jz 0x10099519 */
            ii(0x1009_94fd, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1009_9500, 3); add(ebx, 0x19);                         /* add ebx, 0x19 */
            ii(0x1009_9503, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_9506, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_9509, 5); calld(Definitions.my_ctor_c12, 0xcb5e); /* call 0x100a606c */
            ii(0x1009_950e, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1009_9511, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1009_9514, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_9517, 2); jmpd(0x1009_951f, 0x6); goto l_0x1009_951f; /* jmp 0x1009951f */
        l_0x1009_9519:
            ii(0x1009_9519, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_951c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
        l_0x1009_951f:
            ii(0x1009_951f, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_9522, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1009_9525, 5); calld(0x1008_a914, -0xec16);            /* call 0x1008a914 */
            ii(0x1009_952a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_952d, 4); mov(memb_a32[ds, eax + 0x1d], 0x1);     /* mov byte [eax+0x1d], 0x1 */
            ii(0x1009_9531, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_9534, 3); mov(eax, memd_a32[ds, eax + 0x11]);     /* mov eax, [eax+0x11] */
            ii(0x1009_9537, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_953a, 5); calld(0x100c_defa, 0x3_49bb);           /* call 0x100cdefa */
            ii(0x1009_953f, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1009_9542, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1009_9545, 5); calld(0x1008_a7dc, -0xed6e);            /* call 0x1008a7dc */
            ii(0x1009_954a, 5); calld(0x100a_63bc, 0xce6d);             /* call 0x100a63bc */
            ii(0x1009_954f, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1009_9552, 5); calld(0x1008_a868, -0xecef);            /* call 0x1008a868 */
            ii(0x1009_9557, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_9559, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1009_955e, 5); calld(0x100a_4d50, 0xb7ed);             /* call 0x100a4d50 */
            ii(0x1009_9563, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_9565, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1009_9568, 5); calld(0x1008_8cbc, -0x1_08b1);          /* call 0x10088cbc */
        l_0x1009_956d:
            ii(0x1009_956d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_9570, 4); cmp(memb_a32[ds, eax + 0x1d], 0x5);     /* cmp byte [eax+0x1d], 0x5 */
            ii(0x1009_9574, 2); if(jzd(0x1009_957e, 0x8)) goto l_0x1009_957e; /* jz 0x1009957e */
            ii(0x1009_9576, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_9579, 5); calld(0x1009_9110, -0x46e);             /* call 0x10099110 */
        l_0x1009_957e:
            ii(0x1009_957e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_9580, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_9581, 1); popd(edi);                              /* pop edi */
            ii(0x1009_9582, 1); popd(esi);                              /* pop esi */
            ii(0x1009_9583, 1); popd(edx);                              /* pop edx */
            ii(0x1009_9584, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_9585, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_9586, 1); retd(); return;                         /* ret */
        }
    }
}
