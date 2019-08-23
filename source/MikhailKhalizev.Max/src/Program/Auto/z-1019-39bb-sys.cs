using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_39bb-54109b7b")]
        public void /* sys */ Method_1019_39bb()
        {
            ii(0x1019_39bb, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_39bc, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_39bd, 1); pushd(edx);                             /* push edx */
            ii(0x1019_39be, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1019_39c0, 3); shl(ecx, 0x2);                          /* shl ecx, 0x2 */
            ii(0x1019_39c3, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1019_39c6, 2); sub(ebx, ecx);                          /* sub ebx, ecx */
            ii(0x1019_39c8, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1019_39cb, 2); sub(edx, ecx);                          /* sub edx, ecx */
            ii(0x1019_39cd, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1019_39cf, 2); rep_a32(() => movsd_a32());             /* rep movsd */
            ii(0x1019_39d1, 2); add(esi, ebx);                          /* add esi, ebx */
            ii(0x1019_39d3, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1019_39d5, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1019_39d7, 2); rep_a32(() => movsd_a32());             /* rep movsd */
            ii(0x1019_39d9, 2); add(esi, ebx);                          /* add esi, ebx */
            ii(0x1019_39db, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1019_39dd, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1019_39df, 2); rep_a32(() => movsd_a32());             /* rep movsd */
            ii(0x1019_39e1, 2); add(esi, ebx);                          /* add esi, ebx */
            ii(0x1019_39e3, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1019_39e5, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1019_39e7, 2); rep_a32(() => movsd_a32());             /* rep movsd */
            ii(0x1019_39e9, 2); add(esi, ebx);                          /* add esi, ebx */
            ii(0x1019_39eb, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1019_39ed, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1019_39ef, 2); rep_a32(() => movsd_a32());             /* rep movsd */
            ii(0x1019_39f1, 2); add(esi, ebx);                          /* add esi, ebx */
            ii(0x1019_39f3, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1019_39f5, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1019_39f7, 2); rep_a32(() => movsd_a32());             /* rep movsd */
            ii(0x1019_39f9, 2); add(esi, ebx);                          /* add esi, ebx */
            ii(0x1019_39fb, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1019_39fd, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1019_39ff, 2); rep_a32(() => movsd_a32());             /* rep movsd */
            ii(0x1019_3a01, 2); add(esi, ebx);                          /* add esi, ebx */
            ii(0x1019_3a03, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1019_3a05, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1019_3a07, 2); rep_a32(() => movsd_a32());             /* rep movsd */
            ii(0x1019_3a09, 3); sub(esi, memd_a32[ss, ebp - 0x10]);     /* sub esi, [ebp-0x10] */
            ii(0x1019_3a0c, 3); sub(edi, memd_a32[ss, ebp - 0x14]);     /* sub edi, [ebp-0x14] */
            ii(0x1019_3a0f, 1); popd(edx);                              /* pop edx */
            ii(0x1019_3a10, 1); popd(ecx);                              /* pop ecx */
            ii(0x1019_3a11, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_3a12, 1); retd();                                 /* ret */
        }
    }
}
