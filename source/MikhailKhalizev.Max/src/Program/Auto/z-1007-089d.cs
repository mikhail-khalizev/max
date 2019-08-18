using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_089d-df676931")]
        public void Method_1007_089d()
        {
            ii(0x1007_089d, 7); mov(memd_a32[ss, ebp - 0x24], 0);       /* mov dword [ebp-0x24], 0x0 */
            ii(0x1007_08a4, 2); jmpd(0x1007_08ac, 0x6); goto l_0x1007_08ac; /* jmp 0x100708ac */
        l_0x1007_08a6:
            ii(0x1007_08a6, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1007_08a9, 3); inc(memd_a32[ss, ebp - 0x24]);          /* inc dword [ebp-0x24] */
        l_0x1007_08ac:
            ii(0x1007_08ac, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1007_08af, 4); cmp(ax, memw_a32[ss, ebp + 0x10]);      /* cmp ax, [ebp+0x10] */
            ii(0x1007_08b3, 6); if(jged(0x1007_09b2, 0xf9)) goto l_0x1007_09b2; /* jge 0x100709b2 */
            ii(0x1007_08b9, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_08bc, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1007_08bf, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_08c1, 2); if(jld(0x1007_08d2, 0xf)) goto l_0x1007_08d2; /* jl 0x100708d2 */
            ii(0x1007_08c3, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_08c6, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x1007_08c9, 7); cmp(ax, memw_a32[ds, 0x101c_8172]);     /* cmp ax, [0x101c8172] */
            ii(0x1007_08d0, 2); if(jld(0x1007_08d4, 0x2)) goto l_0x1007_08d4; /* jl 0x100708d4 */
        l_0x1007_08d2:
            ii(0x1007_08d2, 2); jmpd(0x1007_08de, 0xa); goto l_0x1007_08de; /* jmp 0x100708de */
        l_0x1007_08d4:
            ii(0x1007_08d4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_08d7, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1007_08da, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_08dc, 2); if(jged(0x1007_08e0, 0x2)) goto l_0x1007_08e0; /* jge 0x100708e0 */
        l_0x1007_08de:
            ii(0x1007_08de, 2); jmpd(0x1007_08ef, 0xf); goto l_0x1007_08ef; /* jmp 0x100708ef */
        l_0x1007_08e0:
            ii(0x1007_08e0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_08e3, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x1007_08e6, 7); cmp(ax, memw_a32[ds, 0x101c_8174]);     /* cmp ax, [0x101c8174] */
            ii(0x1007_08ed, 2); if(jld(0x1007_08f4, 0x5)) goto l_0x1007_08f4; /* jl 0x100708f4 */
        l_0x1007_08ef:
            ii(0x1007_08ef, 5); jmpd(0x1007_099b, 0xa7); goto l_0x1007_099b; /* jmp 0x1007099b */
        l_0x1007_08f4:
            ii(0x1007_08f4, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1007_08f7, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1007_08fa, 5); jmpd(0x1007_097f, 0x80); goto l_0x1007_097f; /* jmp 0x1007097f */
        l_0x1007_08ff:
            ii(0x1007_08ff, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1007_0904, 1); pushd(eax);                             /* push eax */
            ii(0x1007_0905, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_0908, 3); movsx(ecx, memw_a32[ds, eax]);          /* movsx ecx, word [eax] */
            ii(0x1007_090b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_090e, 3); movsx(ebx, memw_a32[ds, eax]);          /* movsx ebx, word [eax] */
            ii(0x1007_0911, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1007_0914, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1007_0917, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1007_0919, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1007_091c, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1007_0920, 5); calld(0x1007_02b9, -0x66c);             /* call 0x100702b9 */
            ii(0x1007_0925, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x1007_0928, 2); if(jzd(0x1007_0936, 0xc)) goto l_0x1007_0936; /* jz 0x10070936 */
            ii(0x1007_092a, 7); mov(memd_a32[ss, ebp - 0x34], 0x1);     /* mov dword [ebp-0x34], 0x1 */
            ii(0x1007_0931, 5); jmpd(0x1007_09b9, 0x83); goto l_0x1007_09b9; /* jmp 0x100709b9 */
        l_0x1007_0936:
            ii(0x1007_0936, 2); jmpd(0x1007_099b, 0x63); goto l_0x1007_099b; /* jmp 0x1007099b */
        l_0x1007_0938:
            ii(0x1007_0938, 5); calld(0x1007_6034, 0x56f7);             /* call 0x10076034 */
            ii(0x1007_093d, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1007_093f, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1007_0941, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_0944, 3); movsx(ebx, memw_a32[ds, eax]);          /* movsx ebx, word [eax] */
            ii(0x1007_0947, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_094a, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x1007_094d, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1007_0950, 5); calld(0x1007_4c30, 0x42db);             /* call 0x10074c30 */
            ii(0x1007_0955, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_0957, 2); if(jzd(0x1007_097b, 0x22)) goto l_0x1007_097b; /* jz 0x1007097b */
            ii(0x1007_0959, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1007_095c, 3); mov(ecx, memd_a32[ds, eax + 0x10]);     /* mov ecx, [eax+0x10] */
            ii(0x1007_095f, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x1007_0962, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_0965, 3); movsx(ebx, memw_a32[ds, eax]);          /* movsx ebx, word [eax] */
            ii(0x1007_0968, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_096b, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x1007_096e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1007_0971, 5); calld(0x1007_0d68, 0x3f2);              /* call 0x10070d68 */
            ii(0x1007_0976, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x1007_0979, 2); jmpd(0x1007_09b9, 0x3e); goto l_0x1007_09b9; /* jmp 0x100709b9 */
        l_0x1007_097b:
            ii(0x1007_097b, 2); jmpd(0x1007_099b, 0x1e); goto l_0x1007_099b; /* jmp 0x1007099b */
        l_0x1007_097d:
            ii(0x1007_097d, 2); jmpd(0x1007_099b, 0x1c); goto l_0x1007_099b; /* jmp 0x1007099b */
        l_0x1007_097f:
            ii(0x1007_097f, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1007_0982, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x1007_0985, 5); cmp(memw_a32[ss, ebp - 0x38], 0);       /* cmp word [ebp-0x38], 0x0 */
            ii(0x1007_098a, 6); if(jbed(0x1007_08ff, -0x91)) goto l_0x1007_08ff; /* jbe 0x100708ff */
            ii(0x1007_0990, 5); cmp(memw_a32[ss, ebp - 0x38], 0x1);     /* cmp word [ebp-0x38], 0x1 */
            ii(0x1007_0995, 2); if(jzd(0x1007_0938, -0x5f)) goto l_0x1007_0938; /* jz 0x10070938 */
            ii(0x1007_0997, 2); jmpd(0x1007_097d, -0x1c); goto l_0x1007_097d; /* jmp 0x1007097d */
        //    ii(0x1007_0999, 2); jmpd(0x1007_097d, -0x1e); goto l_0x1007_097d; /* jmp 0x1007097d */
        l_0x1007_099b:
            ii(0x1007_099b, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1007_099e, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1007_09a1, 3); add(memw_a32[ds, edx], ax);             /* add [edx], ax */
            ii(0x1007_09a4, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1007_09a7, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1007_09aa, 3); add(memw_a32[ds, edx], ax);             /* add [edx], ax */
            ii(0x1007_09ad, 5); jmpd(0x1007_08a6, -0x10c); goto l_0x1007_08a6; /* jmp 0x100708a6 */
        l_0x1007_09b2:
            ii(0x1007_09b2, 7); mov(memd_a32[ss, ebp - 0x34], 0);       /* mov dword [ebp-0x34], 0x0 */
        l_0x1007_09b9:
            ii(0x1007_09b9, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1007_09bc, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_09be, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_09bf, 1); popd(edi);                              /* pop edi */
            ii(0x1007_09c0, 1); popd(esi);                              /* pop esi */
            ii(0x1007_09c1, 3); retd(0xc); return;                      /* ret 0xc */
        }
    }
}
