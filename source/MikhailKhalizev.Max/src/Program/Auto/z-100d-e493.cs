using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("884ae870-86a5-441c-ba48-5d1fe2cf5aa1")]
        public void Method_100d_e493()
        {
            ii(0x100d_e493, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x100d_e498, 5); calld(Definitions.sys_check_available_stack_size, 0x8_78b5); /* call 0x10165d52 */
            ii(0x100d_e49d, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_e49e, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_e49f, 1); pushd(edx);                             /* push edx */
            ii(0x100d_e4a0, 1); pushd(esi);                             /* push esi */
            ii(0x100d_e4a1, 1); pushd(edi);                             /* push edi */
            ii(0x100d_e4a2, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_e4a3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_e4a5, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100d_e4ab, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100d_e4ae, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_e4b1, 6); mov(eax, memd_a32[ds, eax + 0x345]);    /* mov eax, [eax+0x345] */
            ii(0x100d_e4b7, 5); calld(0x100d_0149, -0xe373);            /* call 0x100d0149 */
            ii(0x100d_e4bc, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_e4bf, 3); lea(edx, ebp - 0x8);                    /* lea edx, [ebp-0x8] */
            ii(0x100d_e4c2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_e4c5, 5); add(eax, 0x3af);                        /* add eax, 0x3af */
            ii(0x100d_e4ca, 5); calld(0x1008_b268, -0x5_3267);          /* call 0x1008b268 */
            ii(0x100d_e4cf, 1); cwde();                                 /* cwde */
            ii(0x100d_e4d0, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_e4d2, 6); if(jld(0x100d_e56c, 0x94)) goto l_0x100d_e56c; /* jl 0x100de56c */
            ii(0x100d_e4d8, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100d_e4dc, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100d_e4df, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100d_e4e2, 6); add(edx, 0x1cf);                        /* add edx, 0x1cf */
            ii(0x100d_e4e8, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100d_e4ea, 5); calld(0x1007_6730, -0x6_7dbf);          /* call 0x10076730 */
            ii(0x100d_e4ef, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100d_e4f1, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100d_e4f6, 5); mov(eax, 0x19);                         /* mov eax, 0x19 */
            ii(0x100d_e4fb, 5); calld(0x1007_1e00, -0x6_c700);          /* call 0x10071e00 */
            ii(0x100d_e500, 4); mov(dx, memw_a32[ds, ebx + 0x8]);       /* mov dx, [ebx+0x8] */
            ii(0x100d_e504, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100d_e507, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x100d_e50a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100d_e50d, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100d_e510, 4); cmp(ax, memw_a32[ds, edx + 0x4f]);      /* cmp ax, [edx+0x4f] */
            ii(0x100d_e514, 2); if(jgd(0x100d_e56c, 0x56)) goto l_0x100d_e56c; /* jg 0x100de56c */
            ii(0x100d_e516, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100d_e51a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_e51d, 6); mov(eax, memd_a32[ds, eax + 0x3bb]);    /* mov eax, [eax+0x3bb] */
            ii(0x100d_e523, 5); calld(0x100d_0700, -0xde28);            /* call 0x100d0700 */
            ii(0x100d_e528, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100d_e52b, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100d_e52e, 4); sub(memw_a32[ds, edx + 0x4f], ax);      /* sub [edx+0x4f], ax */
            ii(0x100d_e532, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_e535, 4); mov(ax, memw_a32[ds, eax + 0x4f]);      /* mov ax, [eax+0x4f] */
            ii(0x100d_e539, 4); cmp(ax, memw_a32[ss, ebp - 0xc]);       /* cmp ax, [ebp-0xc] */
            ii(0x100d_e53d, 2); if(jged(0x100d_e556, 0x17)) goto l_0x100d_e556; /* jge 0x100de556 */
            ii(0x100d_e53f, 5); calld(0x100d_51c4, -0x9380);            /* call 0x100d51c4 */
            ii(0x100d_e544, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_e546, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100d_e548, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_e54b, 6); mov(eax, memd_a32[ds, eax + 0x3db]);    /* mov eax, [eax+0x3db] */
            ii(0x100d_e551, 5); calld(0x100c_fb06, -0xea50);            /* call 0x100cfb06 */
        l_0x100d_e556:
            ii(0x100d_e556, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_e559, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100d_e55c, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_e55f, 3); mov(ebx, memd_a32[ds, eax + 0x13]);     /* mov ebx, [eax+0x13] */
            ii(0x100d_e562, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100d_e566, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_e569, 3); calld_abs(memd_a32[ds, ebx + 0x18]);    /* call dword [ebx+0x18] */
        l_0x100d_e56c:
            ii(0x100d_e56c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_e56e, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_e56f, 1); popd(edi);                              /* pop edi */
            ii(0x100d_e570, 1); popd(esi);                              /* pop esi */
            ii(0x100d_e571, 1); popd(edx);                              /* pop edx */
            ii(0x100d_e572, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_e573, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_e574, 1); retd(); return;                         /* ret */
        }
    }
}
