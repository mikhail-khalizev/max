using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_796c-d0590675")]
        public void Method_100a_796c()
        {
            ii(0x100a_796c, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100a_7971, 5); calld(Definitions.sys_check_available_stack_size, 0xb_e3dc); /* call 0x10165d52 */
            ii(0x100a_7976, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_7977, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_7978, 1); pushd(esi);                             /* push esi */
            ii(0x100a_7979, 1); pushd(edi);                             /* push edi */
            ii(0x100a_797a, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_797b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_797d, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100a_7983, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_7986, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_7989, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_798c, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x100a_798f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_7992, 6); imul(eax, eax, 0xc5);                   /* imul eax, eax, 0xc5 */
            ii(0x100a_7998, 5); mov(edx, 0x101c_31c4);                  /* mov edx, 0x101c31c4 */
            ii(0x100a_799d, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100a_799f, 5); calld(0x1008_a0c8, -0x1_d8dc);          /* call 0x1008a0c8 */
            ii(0x100a_79a4, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100a_79a7, 5); calld(0x100a_a9b0, 0x3004);             /* call 0x100aa9b0 */
            ii(0x100a_79ac, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100a_79af, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_79b2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_79b5, 3); add(eax, 0x14);                         /* add eax, 0x14 */
            ii(0x100a_79b8, 5); calld(0x100a_a8c4, 0x2f07);             /* call 0x100aa8c4 */
            ii(0x100a_79bd, 4); cmp(memd_a32[ss, ebp - 0x10], 0);       /* cmp dword [ebp-0x10], 0x0 */
            ii(0x100a_79c1, 2); if(jzd(0x100a_7a18, 0x55)) goto l_0x100a_7a18; /* jz 0x100a7a18 */
            ii(0x100a_79c3, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x100a_79ca, 2); jmpd(0x100a_79d2, 0x6); goto l_0x100a_79d2; /* jmp 0x100a79d2 */
        l_0x100a_79cc:
            ii(0x100a_79cc, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_79cf, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
        l_0x100a_79d2:
            ii(0x100a_79d2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_79d5, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100a_79d8, 5); calld(Definitions.my_3_get_count, -0x1_c55d); /* call 0x1008b480 */
            ii(0x100a_79dd, 4); cmp(ax, memw_a32[ss, ebp - 0xc]);       /* cmp ax, [ebp-0xc] */
            ii(0x100a_79e1, 2); if(jled(0x100a_7a18, 0x35)) goto l_0x100a_7a18; /* jle 0x100a7a18 */
            ii(0x100a_79e3, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x100a_79e7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_79ea, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100a_79ed, 5); calld(0x100a_aa28, 0x3036);             /* call 0x100aaa28 */
            ii(0x100a_79f2, 3); movsx(ebx, memw_a32[ds, eax]);          /* movsx ebx, word [eax] */
            ii(0x100a_79f5, 3); shl(ebx, 0x2);                          /* shl ebx, 0x2 */
            ii(0x100a_79f8, 3); add(ebx, memd_a32[ss, ebp - 0x10]);     /* add ebx, [ebp-0x10] */
            ii(0x100a_79fb, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x100a_79ff, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_7a02, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100a_7a05, 5); calld(0x100a_aa28, 0x301e);             /* call 0x100aaa28 */
            ii(0x100a_7a0a, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100a_7a0c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_7a0f, 2); mov(edx, memd_a32[ds, ebx]);            /* mov edx, [ebx] */
            ii(0x100a_7a11, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100a_7a13, 3); or(memb_a32[ds, eax], 0x8);             /* or byte [eax], 0x8 */
            ii(0x100a_7a16, 2); jmpd(0x100a_79cc, -0x4c); goto l_0x100a_79cc; /* jmp 0x100a79cc */
        l_0x100a_7a18:
            ii(0x100a_7a18, 5); calld(0x100a_b288, 0x386b);             /* call 0x100ab288 */
            ii(0x100a_7a1d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_7a1f, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100a_7a21, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_7a24, 5); calld(0x100a_28ff, -0x512a);            /* call 0x100a28ff */
            ii(0x100a_7a29, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_7a2b, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_7a2c, 1); popd(edi);                              /* pop edi */
            ii(0x100a_7a2d, 1); popd(esi);                              /* pop esi */
            ii(0x100a_7a2e, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_7a2f, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_7a30, 1); retd();                                 /* ret */
        }
    }
}
