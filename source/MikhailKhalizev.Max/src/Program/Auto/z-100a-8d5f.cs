using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_8d5f-654a98b9")]
        public void Method_100a_8d5f()
        {
            ii(0x100a_8d5f, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x100a_8d64, 5); calld(Definitions.sys_check_available_stack_size, 0xb_cfe9); /* call 0x10165d52 */
            ii(0x100a_8d69, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_8d6a, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_8d6b, 1); pushd(edx);                             /* push edx */
            ii(0x100a_8d6c, 1); pushd(esi);                             /* push esi */
            ii(0x100a_8d6d, 1); pushd(edi);                             /* push edi */
            ii(0x100a_8d6e, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_8d6f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_8d71, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100a_8d77, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_8d7a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_8d7d, 4); test(memb_a32[ds, eax + 0x13], 0x2);    /* test byte [eax+0x13], 0x2 */
            ii(0x100a_8d81, 6); if(jzd(0x100a_8e34, 0xad)) goto l_0x100a_8e34; /* jz 0x100a8e34 */
            ii(0x100a_8d87, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_8d8a, 5); cmp(memw_a32[ds, eax + 0x8], 0x27);     /* cmp word [eax+0x8], 0x27 */
            ii(0x100a_8d8f, 2); if(jnzd(0x100a_8dbe, 0x2d)) goto l_0x100a_8dbe; /* jnz 0x100a8dbe */
            ii(0x100a_8d91, 5); mov(ecx, 0x3);                          /* mov ecx, 0x3 */
            ii(0x100a_8d96, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_8d99, 3); mov(ebx, memd_a32[ds, eax + 0x1a]);     /* mov ebx, [eax+0x1a] */
            ii(0x100a_8d9c, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100a_8d9f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_8da2, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x100a_8da5, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_8da8, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100a_8dab, 5); calld(0x1007_6aac, -0x3_2304);          /* call 0x10076aac */
            ii(0x100a_8db0, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_8db2, 5); mov(eax, 0x101c_34d8);                  /* mov eax, 0x101c34d8 */
            ii(0x100a_8db7, 2); mov(ebx, ecx);                          /* mov ebx, ecx */
            ii(0x100a_8db9, 5); calld(0x100c_95c4, 0x2_0806);           /* call 0x100c95c4 */
        l_0x100a_8dbe:
            ii(0x100a_8dbe, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_8dc1, 5); cmp(memw_a32[ds, eax + 0x8], 0xc);      /* cmp word [eax+0x8], 0xc */
            ii(0x100a_8dc6, 2); if(jnzd(0x100a_8df5, 0x2d)) goto l_0x100a_8df5; /* jnz 0x100a8df5 */
            ii(0x100a_8dc8, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x100a_8dcd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_8dd0, 3); mov(ebx, memd_a32[ds, eax + 0x1a]);     /* mov ebx, [eax+0x1a] */
            ii(0x100a_8dd3, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100a_8dd6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_8dd9, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x100a_8ddc, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_8ddf, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100a_8de2, 5); calld(0x1007_6aac, -0x3_233b);          /* call 0x10076aac */
            ii(0x100a_8de7, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_8de9, 5); mov(eax, 0x101c_34d8);                  /* mov eax, 0x101c34d8 */
            ii(0x100a_8dee, 2); mov(ebx, ecx);                          /* mov ebx, ecx */
            ii(0x100a_8df0, 5); calld(0x100c_95c4, 0x2_07cf);           /* call 0x100c95c4 */
        l_0x100a_8df5:
            ii(0x100a_8df5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_8df8, 5); cmp(memw_a32[ds, eax + 0x8], 0xc);      /* cmp word [eax+0x8], 0xc */
            ii(0x100a_8dfd, 2); if(jzd(0x100a_8e08, 0x9)) goto l_0x100a_8e08; /* jz 0x100a8e08 */
            ii(0x100a_8dff, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_8e02, 4); test(memb_a32[ds, eax + 0x12], 0x1);    /* test byte [eax+0x12], 0x1 */
            ii(0x100a_8e06, 2); if(jzd(0x100a_8e0a, 0x2)) goto l_0x100a_8e0a; /* jz 0x100a8e0a */
        l_0x100a_8e08:
            ii(0x100a_8e08, 2); jmpd(0x100a_8e34, 0x2a); goto l_0x100a_8e34; /* jmp 0x100a8e34 */
        l_0x100a_8e0a:
            ii(0x100a_8e0a, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100a_8e0c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_8e0f, 3); mov(ebx, memd_a32[ds, eax + 0x1a]);     /* mov ebx, [eax+0x1a] */
            ii(0x100a_8e12, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100a_8e15, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_8e18, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x100a_8e1b, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_8e1e, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_8e21, 5); calld(0x1007_6aac, -0x3_237a);          /* call 0x10076aac */
            ii(0x100a_8e26, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_8e28, 5); mov(eax, 0x101c_34d8);                  /* mov eax, 0x101c34d8 */
            ii(0x100a_8e2d, 2); mov(ebx, ecx);                          /* mov ebx, ecx */
            ii(0x100a_8e2f, 5); calld(0x100c_95c4, 0x2_0790);           /* call 0x100c95c4 */
        l_0x100a_8e34:
            ii(0x100a_8e34, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_8e37, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x100a_8e3a, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_8e3f, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100a_8e45, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100a_8e4b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_8e50, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100a_8e53, 2); if(jnzd(0x100a_8e67, 0x12)) goto l_0x100a_8e67; /* jnz 0x100a8e67 */
            ii(0x100a_8e55, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_8e58, 5); calld(0x1007_623c, -0x3_2c21);          /* call 0x1007623c */
            ii(0x100a_8e5d, 3); mov(eax, memd_a32[ds, eax + 0x19]);     /* mov eax, [eax+0x19] */
            ii(0x100a_8e60, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_8e63, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_8e65, 2); if(jgd(0x100a_8e69, 0x2)) goto l_0x100a_8e69; /* jg 0x100a8e69 */
        l_0x100a_8e67:
            ii(0x100a_8e67, 2); jmpd(0x100a_8e89, 0x20); goto l_0x100a_8e89; /* jmp 0x100a8e89 */
        l_0x100a_8e69:
            ii(0x100a_8e69, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_8e6c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_8e6f, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x100a_8e72, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_8e77, 6); imul(ebx, eax, 0xc5);                   /* imul ebx, eax, 0xc5 */
            ii(0x100a_8e7d, 5); mov(eax, 0x101c_31c4);                  /* mov eax, 0x101c31c4 */
            ii(0x100a_8e82, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100a_8e84, 5); calld(0x100b_a18e, 0x1_1305);           /* call 0x100ba18e */
        l_0x100a_8e89:
            ii(0x100a_8e89, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_8e8b, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_8e8c, 1); popd(edi);                              /* pop edi */
            ii(0x100a_8e8d, 1); popd(esi);                              /* pop esi */
            ii(0x100a_8e8e, 1); popd(edx);                              /* pop edx */
            ii(0x100a_8e8f, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_8e90, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_8e91, 1); retd(); return;                         /* ret */
        }
    }
}
