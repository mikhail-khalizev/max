using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f814fdc8-31aa-493c-972e-4bfb72a45db3")]
        public void Method_1007_547e()
        {
            ii(0x1007_547e, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1007_5483, 5); calld(Definitions.sys_check_available_stack_size, 0xf_08ca); /* call 0x10165d52 */
            ii(0x1007_5488, 1); pushd(esi);                             /* push esi */
            ii(0x1007_5489, 1); pushd(edi);                             /* push edi */
            ii(0x1007_548a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_548b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_548d, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1007_5493, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1007_5496, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1007_5499, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1007_549c, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x1007_549f, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1007_54a3, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_54a5, 2); if(jld(0x1007_54b3, 0xc)) goto l_0x1007_54b3; /* jl 0x100754b3 */
            ii(0x1007_54a7, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_54aa, 7); cmp(ax, memw_a32[ds, 0x101c_8172]);     /* cmp ax, [0x101c8172] */
            ii(0x1007_54b1, 2); if(jld(0x1007_54b5, 0x2)) goto l_0x1007_54b5; /* jl 0x100754b5 */
        l_0x1007_54b3:
            ii(0x1007_54b3, 2); jmpd(0x1007_54bd, 0x8); goto l_0x1007_54bd; /* jmp 0x100754bd */
        l_0x1007_54b5:
            ii(0x1007_54b5, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1007_54b9, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_54bb, 2); if(jged(0x1007_54bf, 0x2)) goto l_0x1007_54bf; /* jge 0x100754bf */
        l_0x1007_54bd:
            ii(0x1007_54bd, 2); jmpd(0x1007_54cb, 0xc); goto l_0x1007_54cb; /* jmp 0x100754cb */
        l_0x1007_54bf:
            ii(0x1007_54bf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_54c2, 7); cmp(ax, memw_a32[ds, 0x101c_8174]);     /* cmp ax, [0x101c8174] */
            ii(0x1007_54c9, 2); if(jld(0x1007_54d4, 0x9)) goto l_0x1007_54d4; /* jl 0x100754d4 */
        l_0x1007_54cb:
            ii(0x1007_54cb, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x1007_54d2, 2); jmpd(0x1007_552e, 0x5a); goto l_0x1007_552e; /* jmp 0x1007552e */
        l_0x1007_54d4:
            ii(0x1007_54d4, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1007_54d7, 3); mov(al, memb_a32[ds, eax + 0x61]);      /* mov al, [eax+0x61] */
            ii(0x1007_54da, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_54df, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1007_54e2, 2); if(jnzd(0x1007_54ed, 0x9)) goto l_0x1007_54ed; /* jnz 0x100754ed */
            ii(0x1007_54e4, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1007_54e7, 4); cmp(memb_a32[ds, eax + 0x50], 0);       /* cmp byte [eax+0x50], 0x0 */
            ii(0x1007_54eb, 2); if(jnzd(0x1007_54ef, 0x2)) goto l_0x1007_54ef; /* jnz 0x100754ef */
        l_0x1007_54ed:
            ii(0x1007_54ed, 2); jmpd(0x1007_5507, 0x18); goto l_0x1007_5507; /* jmp 0x10075507 */
        l_0x1007_54ef:
            ii(0x1007_54ef, 4); movsx(ecx, memw_a32[ss, ebp - 0x4]);    /* movsx ecx, word [ebp-0x4] */
            ii(0x1007_54f3, 4); movsx(ebx, memw_a32[ss, ebp - 0x8]);    /* movsx ebx, word [ebp-0x8] */
            ii(0x1007_54f7, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1007_54fb, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1007_54fe, 5); calld(0x1007_0d68, -0x479b);            /* call 0x10070d68 */
            ii(0x1007_5503, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_5505, 2); if(jnzd(0x1007_5509, 0x2)) goto l_0x1007_5509; /* jnz 0x10075509 */
        l_0x1007_5507:
            ii(0x1007_5507, 2); jmpd(0x1007_5527, 0x1e); goto l_0x1007_5527; /* jmp 0x10075527 */
        l_0x1007_5509:
            ii(0x1007_5509, 5); calld(0x1007_6034, 0xb26);              /* call 0x10076034 */
            ii(0x1007_550e, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1007_5510, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1007_5512, 4); movsx(ebx, memw_a32[ss, ebp - 0x8]);    /* movsx ebx, word [ebp-0x8] */
            ii(0x1007_5516, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1007_551a, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1007_551d, 5); calld(0x1007_4c30, -0x8f2);             /* call 0x10074c30 */
            ii(0x1007_5522, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1007_5525, 2); jmpd(0x1007_552e, 0x7); goto l_0x1007_552e; /* jmp 0x1007552e */
        l_0x1007_5527:
            ii(0x1007_5527, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
        l_0x1007_552e:
            ii(0x1007_552e, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1007_5531, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_5533, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_5534, 1); popd(edi);                              /* pop edi */
            ii(0x1007_5535, 1); popd(esi);                              /* pop esi */
            ii(0x1007_5536, 1); retd(); return;                         /* ret */
        }
    }
}