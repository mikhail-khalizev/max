using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_66b0-c75b09ba")]
        public void /* sys */ Method_1016_66b0()
        {
            ii(0x1016_66b0, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_66b1, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_66b2, 1); pushd(edx);                             /* push edx */
            ii(0x1016_66b3, 1); pushd(esi);                             /* push esi */
            ii(0x1016_66b4, 1); pushd(edi);                             /* push edi */
            ii(0x1016_66b5, 7); cmp(memd_a32[ds, 0x101b_dddc], 0);      /* cmp dword [0x101bdddc], 0x0 */
            ii(0x1016_66bc, 6); if(jnzd(0x1016_675b, 0x99)) goto l_0x1016_675b; /* jnz 0x1016675b */
            ii(0x1016_66c2, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1016_66c7, 6); mov(ecx, memd_a32[ds, 0x101b_ddbc]);    /* mov ecx, [0x101bddbc] */
            ii(0x1016_66cd, 6); mov(memd_a32[ds, 0x101b_dddc], ebx);    /* mov [0x101bdddc], ebx */
            ii(0x1016_66d3, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1016_66d5, 6); if(jzd(0x1016_6753, 0x78)) goto l_0x1016_6753; /* jz 0x10166753 */
            ii(0x1016_66db, 5); calld(/* sys */ 0x1018_5944, 0x1_f264); /* call 0x10185944 */
            ii(0x1016_66e0, 6); mov(ebx, memd_a32[ds, 0x101c_b2d8]);    /* mov ebx, [0x101cb2d8] */
            ii(0x1016_66e6, 1); dec(ebx);                               /* dec ebx */
            ii(0x1016_66e7, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1016_66e9, 2); if(jld(0x1016_6707, 0x1c)) goto l_0x1016_6707; /* jl 0x10166707 */
            ii(0x1016_66eb, 7); lea(edx, ebx * 4 + 0);                  /* lea edx, [ebx*4] */
        l_0x1016_66f2:
            ii(0x1016_66f2, 6); mov(eax, memd_a32[ds, edx + 0x101c_b1fc]); /* mov eax, [edx+0x101cb1fc] */
            ii(0x1016_66f8, 3); sub(edx, 0x4);                          /* sub edx, 0x4 */
            ii(0x1016_66fb, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1016_66fd, 1); dec(ebx);                               /* dec ebx */
            ii(0x1016_66fe, 5); calld(/* sys */ 0x1016_6a34, 0x331);    /* call 0x10166a34 */
            ii(0x1016_6703, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1016_6705, 2); if(jged(0x1016_66f2, -0x15)) goto l_0x1016_66f2; /* jge 0x101666f2 */
        l_0x1016_6707:
            ii(0x1016_6707, 6); mov(esi, memd_a32[ds, 0x101c_b2e0]);    /* mov esi, [0x101cb2e0] */
            ii(0x1016_670d, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1016_670f, 2); if(jzd(0x1016_6718, 0x7)) goto l_0x1016_6718; /* jz 0x10166718 */
            ii(0x1016_6711, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_6713, 5); calld(Definitions.sys_free_internal, 0x1_bd3c); /* call 0x10182454 */
        l_0x1016_6718:
            ii(0x1016_6718, 6); mov(edi, memd_a32[ds, 0x101b_ddd8]);    /* mov edi, [0x101bddd8] */
            ii(0x1016_671e, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1016_6720, 2); if(jzd(0x1016_6729, 0x7)) goto l_0x1016_6729; /* jz 0x10166729 */
            ii(0x1016_6722, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1016_6724, 5); calld(Definitions.sys_free_internal, 0x1_bd2b); /* call 0x10182454 */
        l_0x1016_6729:
            ii(0x1016_6729, 7); cmp(memd_a32[ds, 0x101c_b2d4], 0);      /* cmp dword [0x101cb2d4], 0x0 */
            ii(0x1016_6730, 2); if(jzd(0x1016_6738, 0x6)) goto l_0x1016_6738; /* jz 0x10166738 */
            ii(0x1016_6732, 6); calld_abs(memd_a32[ds, 0x101c_b2d4]);   /* call dword [0x101cb2d4] */
        l_0x1016_6738:
            ii(0x1016_6738, 5); calld(/* sys */ 0x1016_b1e4, 0x4aa7);   /* call 0x1016b1e4 */
            ii(0x1016_673d, 5); calld(/* sys */ 0x1018_5d50, 0x1_f60e); /* call 0x10185d50 */
            ii(0x1016_6742, 5); calld(/* sys */ 0x1016_9f3c, 0x37f5);   /* call 0x10169f3c */
            ii(0x1016_6747, 5); calld(/* sys */ 0x1016_e234, 0x7ae8);   /* call 0x1016e234 */
            ii(0x1016_674c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_674e, 5); mov(memd_a32[ds, 0x101b_ddbc], eax);    /* mov [0x101bddbc], eax */
        l_0x1016_6753:
            ii(0x1016_6753, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_6755, 6); mov(memd_a32[ds, 0x101b_dddc], edx);    /* mov [0x101bdddc], edx */
        l_0x1016_675b:
            ii(0x1016_675b, 1); popd(edi);                              /* pop edi */
            ii(0x1016_675c, 1); popd(esi);                              /* pop esi */
            ii(0x1016_675d, 1); popd(edx);                              /* pop edx */
            ii(0x1016_675e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_675f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_6760, 1); retd();                                 /* ret */
        }
    }
}
