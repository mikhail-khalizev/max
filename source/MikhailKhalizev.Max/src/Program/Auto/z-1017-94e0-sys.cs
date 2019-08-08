using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("97cf36ae-8ea6-43c3-84b8-63599b3ff03e")]
        public void /* sys */ Method_1017_94e0()
        {
            ii(0x1017_94e0, 1); pushd(ebp);                             /* push ebp */
            ii(0x1017_94e1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_94e3, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_94e4, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_94e5, 1); pushd(edx);                             /* push edx */
            ii(0x1017_94e6, 1); pushd(esi);                             /* push esi */
            ii(0x1017_94e7, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1017_94e9, 3); mov(edx, memd_a32[ds, eax + 0x4]);      /* mov edx, [eax+0x4] */
            ii(0x1017_94ec, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_94ee, 2); if(jzd(0x1017_9501, 0x11)) goto l_0x1017_9501; /* jz 0x10179501 */
            ii(0x1017_94f0, 4); cmp(memd_a32[ds, eax + 0xc], 0);        /* cmp dword [eax+0xc], 0x0 */
            ii(0x1017_94f4, 2); if(jzd(0x1017_9501, 0xb)) goto l_0x1017_9501; /* jz 0x10179501 */
            ii(0x1017_94f6, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1017_94f8, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1017_94fa, 2); mov(edx, ds);                           /* mov edx, ds */
            ii(0x1017_94fc, 5); calld(/* sys */ 0x1019_44f0, 0x1_afef); /* call 0x101944f0 */
        l_0x1017_9501:
            ii(0x1017_9501, 4); cmp(memd_a32[ds, esi + 0x8], 0);        /* cmp dword [esi+0x8], 0x0 */
            ii(0x1017_9505, 2); if(jzd(0x1017_9523, 0x1c)) goto l_0x1017_9523; /* jz 0x10179523 */
            ii(0x1017_9507, 7); cmp(memd_a32[ds, 0x1020_9dcc], 0);      /* cmp dword [0x10209dcc], 0x0 */
            ii(0x1017_950e, 2); if(jzd(0x1017_9523, 0x13)) goto l_0x1017_9523; /* jz 0x10179523 */
            ii(0x1017_9510, 2); mov(eax, memd_a32[ds, esi]);            /* mov eax, [esi] */
            ii(0x1017_9512, 1); pushd(eax);                             /* push eax */
            ii(0x1017_9513, 6); calld_abs(memd_a32[ds, 0x1020_9dcc]);   /* call dword [0x10209dcc] */
            ii(0x1017_9519, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1017_951c, 7); mov(memd_a32[ds, esi + 0x8], 0);        /* mov dword [esi+0x8], 0x0 */
        l_0x1017_9523:
            ii(0x1017_9523, 7); mov(memd_a32[ds, esi + 0x4], 0);        /* mov dword [esi+0x4], 0x0 */
            ii(0x1017_952a, 3); lea(esp, ebp - 0x10);                   /* lea esp, [ebp-0x10] */
            ii(0x1017_952d, 1); popd(esi);                              /* pop esi */
            ii(0x1017_952e, 1); popd(edx);                              /* pop edx */
            ii(0x1017_952f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_9530, 1); popd(ebx);                              /* pop ebx */
            ii(0x1017_9531, 1); popd(ebp);                              /* pop ebp */
            ii(0x1017_9532, 1); retd(); return;                         /* ret */
        }
    }
}
