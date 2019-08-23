using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_a4d0-e5f16253")]
        public void /* sys */ Method_1016_a4d0()
        {
            ii(0x1016_a4d0, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_a4d1, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_a4d2, 1); pushd(edx);                             /* push edx */
            ii(0x1016_a4d3, 1); pushd(esi);                             /* push esi */
            ii(0x1016_a4d4, 1); pushd(edi);                             /* push edi */
            ii(0x1016_a4d5, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_a4d6, 6); mov(edi, memd_a32[ds, 0x101c_f964]);    /* mov edi, [0x101cf964] */
            ii(0x1016_a4dc, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_a4de, 3); mov(esi, memd_a32[ds, edi + 0xc]);      /* mov esi, [edi+0xc] */
            ii(0x1016_a4e1, 2); mov(bl, memb_a32[ds, eax]);             /* mov bl, [eax] */
            ii(0x1016_a4e3, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1016_a4e5, 2); test(bl, bl);                           /* test bl, bl */
            ii(0x1016_a4e7, 2); if(jzd(0x1016_a505, 0x1c)) goto l_0x1016_a505; /* jz 0x1016a505 */
        l_0x1016_a4e9:
            ii(0x1016_a4e9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_a4eb, 2); mov(ebp, memd_a32[ds, edi]);            /* mov ebp, [edi] */
            ii(0x1016_a4ed, 2); mov(dl, memb_a32[ds, eax]);             /* mov dl, [eax] */
            ii(0x1016_a4ef, 2); mov(ebx, edi);                          /* mov ebx, edi */
            ii(0x1016_a4f1, 2); cmp(edx, ebp);                          /* cmp edx, ebp */
            ii(0x1016_a4f3, 2); if(jged(0x1016_a4fd, 0x8)) goto l_0x1016_a4fd; /* jge 0x1016a4fd */
            ii(0x1016_a4f5, 3); mov(edx, memd_a32[ds, esi + edx * 8]);  /* mov edx, [esi+edx*8] */
            ii(0x1016_a4f8, 3); add(edx, memd_a32[ds, edi + 0x8]);      /* add edx, [edi+0x8] */
            ii(0x1016_a4fb, 2); add(ecx, edx);                          /* add ecx, edx */
        l_0x1016_a4fd:
            ii(0x1016_a4fd, 3); mov(bh, memb_a32[ds, eax + 0x1]);       /* mov bh, [eax+0x1] */
            ii(0x1016_a500, 1); inc(eax);                               /* inc eax */
            ii(0x1016_a501, 2); test(bh, bh);                           /* test bh, bh */
            ii(0x1016_a503, 2); if(jnzd(0x1016_a4e9, -0x1c)) goto l_0x1016_a4e9; /* jnz 0x1016a4e9 */
        l_0x1016_a505:
            ii(0x1016_a505, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1016_a507, 6); mov(memd_a32[ds, 0x101c_f964], edi);    /* mov [0x101cf964], edi */
            ii(0x1016_a50d, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_a50e, 1); popd(edi);                              /* pop edi */
            ii(0x1016_a50f, 1); popd(esi);                              /* pop esi */
            ii(0x1016_a510, 1); popd(edx);                              /* pop edx */
            ii(0x1016_a511, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_a512, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_a513, 1); retd();                                 /* ret */
        }
    }
}
