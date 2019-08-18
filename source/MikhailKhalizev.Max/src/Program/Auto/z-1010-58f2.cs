using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_58f2-34e68813")]
        public void Method_1010_58f2()
        {
            ii(0x1010_58f2, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1010_58f7, 5); calld(Definitions.sys_check_available_stack_size, 0x6_0456); /* call 0x10165d52 */
            ii(0x1010_58fc, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_58fd, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_58fe, 1); pushd(esi);                             /* push esi */
            ii(0x1010_58ff, 1); pushd(edi);                             /* push edi */
            ii(0x1010_5900, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_5901, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_5903, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1010_5909, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_590c, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x1010_590f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_5912, 7); mov(memb_a32[ds, eax + 0x461], 0);      /* mov byte [eax+0x461], 0x0 */
        l_0x1010_5919:
            ii(0x1010_5919, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_591c, 4); cmp(memb_a32[ds, eax + 0x31], 0);       /* cmp byte [eax+0x31], 0x0 */
            ii(0x1010_5920, 6); if(jnzd(0x1010_59d3, 0xad)) goto l_0x1010_59d3; /* jnz 0x101059d3 */
            ii(0x1010_5926, 5); calld(/* sys */ 0x1016_b208, 0x6_58dd); /* call 0x1016b208 */
            ii(0x1010_592b, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1010_592e, 7); cmp(memb_a32[ds, 0x101c_37d2], 0);      /* cmp byte [0x101c37d2], 0x0 */
            ii(0x1010_5935, 2); if(jzd(0x1010_593e, 0x7)) goto l_0x1010_593e; /* jz 0x1010593e */
            ii(0x1010_5937, 7); mov(memd_a32[ss, ebp - 0xc], 0xd);      /* mov dword [ebp-0xc], 0xd */
        l_0x1010_593e:
            ii(0x1010_593e, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1010_5941, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_5944, 5); calld(0x1010_5655, -0x2f4);             /* call 0x10105655 */
            ii(0x1010_5949, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_594b, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1010_594e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_5950, 6); if(jnzd(0x1010_59ce, 0x78)) goto l_0x1010_59ce; /* jnz 0x101059ce */
            ii(0x1010_5956, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_5959, 7); cmp(memb_a32[ds, eax + 0x458], 0x26);   /* cmp byte [eax+0x458], 0x26 */
            ii(0x1010_5960, 2); if(jnzd(0x1010_5970, 0xe)) goto l_0x1010_5970; /* jnz 0x10105970 */
            ii(0x1010_5962, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_5964, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1010_5969, 5); calld(0x1010_0e32, -0x4b3c);            /* call 0x10100e32 */
            ii(0x1010_596e, 2); jmpd(0x1010_59ce, 0x5e); goto l_0x1010_59ce; /* jmp 0x101059ce */
        l_0x1010_5970:
            ii(0x1010_5970, 7); cmp(memb_a32[ds, 0x101c_391e], 0x8);    /* cmp byte [0x101c391e], 0x8 */
            ii(0x1010_5977, 2); if(jzd(0x1010_5982, 0x9)) goto l_0x1010_5982; /* jz 0x10105982 */
            ii(0x1010_5979, 7); cmp(memb_a32[ds, 0x101c_391e], 0x9);    /* cmp byte [0x101c391e], 0x9 */
            ii(0x1010_5980, 2); if(jnzd(0x1010_598d, 0xb)) goto l_0x1010_598d; /* jnz 0x1010598d */
        l_0x1010_5982:
            ii(0x1010_5982, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_5984, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_5986, 5); calld(0x1010_0e32, -0x4b59);            /* call 0x10100e32 */
            ii(0x1010_598b, 2); jmpd(0x1010_59ce, 0x41); goto l_0x1010_59ce; /* jmp 0x101059ce */
        l_0x1010_598d:
            ii(0x1010_598d, 7); cmp(memb_a32[ds, 0x101c_5630], 0);      /* cmp byte [0x101c5630], 0x0 */
            ii(0x1010_5994, 2); if(jzd(0x1010_59ad, 0x17)) goto l_0x1010_59ad; /* jz 0x101059ad */
            ii(0x1010_5996, 5); calld(0x1012_ac94, 0x2_52f9);           /* call 0x1012ac94 */
            ii(0x1010_599b, 7); cmp(memb_a32[ds, 0x101c_5630], 0x2);    /* cmp byte [0x101c5630], 0x2 */
            ii(0x1010_59a2, 2); if(jnzd(0x1010_59ab, 0x7)) goto l_0x1010_59ab; /* jnz 0x101059ab */
            ii(0x1010_59a4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_59a7, 4); mov(memb_a32[ds, eax + 0x31], 0x1);     /* mov byte [eax+0x31], 0x1 */
        l_0x1010_59ab:
            ii(0x1010_59ab, 2); jmpd(0x1010_59ce, 0x21); goto l_0x1010_59ce; /* jmp 0x101059ce */
        l_0x1010_59ad:
            ii(0x1010_59ad, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x1010_59b4, 2); if(jzd(0x1010_59ce, 0x18)) goto l_0x1010_59ce; /* jz 0x101059ce */
            ii(0x1010_59b6, 5); calld(0x100e_42e4, -0x2_16d7);          /* call 0x100e42e4 */
            ii(0x1010_59bb, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_59c0, 5); calld(0x1012_8835, 0x2_2e70);           /* call 0x10128835 */
            ii(0x1010_59c5, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_59c7, 2); if(jzd(0x1010_59ce, 0x5)) goto l_0x1010_59ce; /* jz 0x101059ce */
            ii(0x1010_59c9, 5); calld(0x1016_2cb8, 0x5_d2ea);           /* call 0x10162cb8 */
        l_0x1010_59ce:
            ii(0x1010_59ce, 5); jmpd(0x1010_5919, -0xba); goto l_0x1010_5919; /* jmp 0x10105919 */
        l_0x1010_59d3:
            ii(0x1010_59d3, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_59d5, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1010_59d8, 3); mov(al, memb_a32[ds, edx + 0x32]);      /* mov al, [edx+0x32] */
            ii(0x1010_59db, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1010_59de, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_59e1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_59e3, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_59e4, 1); popd(edi);                              /* pop edi */
            ii(0x1010_59e5, 1); popd(esi);                              /* pop esi */
            ii(0x1010_59e6, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_59e7, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_59e8, 1); retd(); return;                         /* ret */
        }
    }
}
