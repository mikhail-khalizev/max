using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ba3b4187-067a-4c1a-90e9-3e1181347f4b")]
        public void Method_1010_697a()
        {
            ii(0x1010_697a, 5); pushd(0x38);                            /* push 0x38 */
            ii(0x1010_697f, 5); calld(Definitions.sys_check_available_stack_size, 0x5f3ce); /* call 0x10165d52 */
            ii(0x1010_6984, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_6985, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_6986, 1); pushd(esi);                             /* push esi */
            ii(0x1010_6987, 1); pushd(edi);                             /* push edi */
            ii(0x1010_6988, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_6989, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_698b, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1010_6991, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_6994, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1010_6997, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_699a, 7); cmp(memd_a32[ds, eax + 0x84], 0);       /* cmp dword [eax+0x84], 0x0 */
            ii(0x1010_69a1, 2); if(jnzd(0x1010_69af, 0xc)) goto l_0x1010_69af; /* jnz 0x101069af */
            ii(0x1010_69a3, 7); mov(memd_a32[ss, ebp - 0xc], 0x7fff);   /* mov dword [ebp-0xc], 0x7fff */
            ii(0x1010_69aa, 5); jmpd(0x1010_6a1f, 0x70); goto l_0x1010_6a1f; /* jmp 0x10106a1f */
        l_0x1010_69af:
            ii(0x1010_69af, 5); mov(eax, 0x101a_3b57);                  /* mov eax, 0x101a3b57 */ /* "Unit Volumes" */
            ii(0x1010_69b4, 1); pushd(eax);                             /* push eax */
            ii(0x1010_69b5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_69b8, 1); pushd(eax);                             /* push eax */
            ii(0x1010_69b9, 5); calld(0x1012_36fa, 0x1cd3c);            /* call 0x101236fa */
            ii(0x1010_69be, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1010_69c1, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_69c3, 2); if(jzd(0x1010_6a18, 0x53)) goto l_0x1010_6a18; /* jz 0x10106a18 */
            ii(0x1010_69c5, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1010_69c9, 3); imul(edx, eax, 0x7);                    /* imul edx, eax, 0x7 */
            ii(0x1010_69cc, 5); mov(eax, memd_a32[ds, Definitions.ptr_arr_meta_by_id]); /* mov eax, [0x101c70ec] */
            ii(0x1010_69d1, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1010_69d3, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x1010_69d6, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1010_69d9, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1010_69dd, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1010_69e0, 2); if(jzd(0x1010_6a18, 0x36)) goto l_0x1010_6a18; /* jz 0x10106a18 */
            ii(0x1010_69e2, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1010_69e5, 1); pushd(eax);                             /* push eax */
            ii(0x1010_69e6, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1010_69ea, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_69ed, 6); pushd(memd_a32[ds, eax + 0x101b_b520]); /* push dword [eax+0x101bb520] */
            ii(0x1010_69f3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_69f6, 1); pushd(eax);                             /* push eax */
            ii(0x1010_69f7, 5); calld(0x1012_4113, 0x1d717);            /* call 0x10124113 */
            ii(0x1010_69fc, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1010_69ff, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_6a01, 2); if(jzd(0x1010_6a18, 0x15)) goto l_0x1010_6a18; /* jz 0x10106a18 */
            ii(0x1010_6a03, 7); imul(eax, memd_a32[ss, ebp - 0x14], 0x7fff); /* imul eax, [ebp-0x14], 0x7fff */
            ii(0x1010_6a0a, 5); mov(ebx, 0x64);                         /* mov ebx, 0x64 */
            ii(0x1010_6a0f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_6a11, 2); div(ebx);                               /* div ebx */
            ii(0x1010_6a13, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1010_6a16, 2); jmpd(0x1010_6a1f, 0x7); goto l_0x1010_6a1f; /* jmp 0x10106a1f */
        l_0x1010_6a18:
            ii(0x1010_6a18, 7); mov(memd_a32[ss, ebp - 0xc], 0x7fff);   /* mov dword [ebp-0xc], 0x7fff */
        l_0x1010_6a1f:
            ii(0x1010_6a1f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_6a22, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_6a24, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_6a25, 1); popd(edi);                              /* pop edi */
            ii(0x1010_6a26, 1); popd(esi);                              /* pop esi */
            ii(0x1010_6a27, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_6a28, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_6a29, 1); retd(); return;                         /* ret */
        }
    }
}