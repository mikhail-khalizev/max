using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_6a90-41205256")]
        public void /* sys */ Method_1016_6a90()
        {
            ii(0x1016_6a90, 1); push(ebx);                              /* push ebx */
            ii(0x1016_6a91, 1); push(ecx);                              /* push ecx */
            ii(0x1016_6a92, 1); push(edx);                              /* push edx */
            ii(0x1016_6a93, 1); push(esi);                              /* push esi */
            ii(0x1016_6a94, 5); call(/* sys */ 0x1016_7dac, 0x1313);    /* call 0x10167dac */
            ii(0x1016_6a99, 6); mov(edx, memd[ds, 0x101b_ddbc]);        /* mov edx, [0x101bddbc] */
            ii(0x1016_6a9f, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1016_6aa1, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1016_6aa3, 6); if(jz(0x1016_6bb8, 0x10f)) goto l_0x1016_6bb8; /* jz 0x10166bb8 */
            ii(0x1016_6aa9, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_6aab, 6); if(jz(0x1016_6bb8, 0x107)) goto l_0x1016_6bb8; /* jz 0x10166bb8 */
            ii(0x1016_6ab1, 5); mov(ebx, 5);                            /* mov ebx, 0x5 */
            ii(0x1016_6ab6, 3); mov(ecx, memd[ds, eax + 0x18]);         /* mov ecx, [eax+0x18] */
            ii(0x1016_6ab9, 3); mov(eax, memd[ds, eax + 0x2c]);         /* mov eax, [eax+0x2c] */
            ii(0x1016_6abc, 3); lea(edx, memd[ds, ecx - 0xa]);          /* lea edx, [ecx-0xa] */
            ii(0x1016_6abf, 3); add(eax, 5);                            /* add eax, 0x5 */
            ii(0x1016_6ac2, 5); call(/* sys */ 0x1016_af44, 0x447d);    /* call 0x1016af44 */
            ii(0x1016_6ac7, 5); mov(edx, 5);                            /* mov edx, 0x5 */
            ii(0x1016_6acc, 3); mov(ecx, memd[ds, esi + 0x18]);         /* mov ecx, [esi+0x18] */
            ii(0x1016_6acf, 3); mov(ebx, memd[ds, esi + 0x1c]);         /* mov ebx, [esi+0x1c] */
            ii(0x1016_6ad2, 3); mov(eax, memd[ds, esi + 0x2c]);         /* mov eax, [esi+0x2c] */
            ii(0x1016_6ad5, 5); call(/* sys */ 0x1016_af44, 0x446a);    /* call 0x1016af44 */
            ii(0x1016_6ada, 3); mov(ecx, memd[ds, esi + 0x18]);         /* mov ecx, [esi+0x18] */
            ii(0x1016_6add, 3); mov(eax, memd[ds, esi + 0x2c]);         /* mov eax, [esi+0x2c] */
            ii(0x1016_6ae0, 5); mov(edx, 5);                            /* mov edx, 0x5 */
            ii(0x1016_6ae5, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1016_6ae7, 3); mov(ebx, memd[ds, esi + 0x1c]);         /* mov ebx, [esi+0x1c] */
            ii(0x1016_6aea, 3); sub(eax, 5);                            /* sub eax, 0x5 */
            ii(0x1016_6aed, 5); call(/* sys */ 0x1016_af44, 0x4452);    /* call 0x1016af44 */
            ii(0x1016_6af2, 3); mov(ecx, memd[ds, esi + 0x18]);         /* mov ecx, [esi+0x18] */
            ii(0x1016_6af5, 3); mov(ebx, memd[ds, esi + 0x1c]);         /* mov ebx, [esi+0x1c] */
            ii(0x1016_6af8, 3); lea(edx, memd[ds, ecx - 0xa]);          /* lea edx, [ecx-0xa] */
            ii(0x1016_6afb, 3); sub(ebx, 5);                            /* sub ebx, 0x5 */
            ii(0x1016_6afe, 3); imul(ebx, ecx);                         /* imul ebx, ecx */
            ii(0x1016_6b01, 3); mov(eax, memd[ds, esi + 0x2c]);         /* mov eax, [esi+0x2c] */
            ii(0x1016_6b04, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1016_6b06, 5); mov(ebx, 5);                            /* mov ebx, 0x5 */
            ii(0x1016_6b0b, 3); add(eax, 5);                            /* add eax, 0x5 */
            ii(0x1016_6b0e, 5); call(/* sys */ 0x1016_af44, 0x4431);    /* call 0x1016af44 */
            ii(0x1016_6b13, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_6b15, 5); mov(al, memb[ds, 0x1020_0520]);         /* mov al, [0x10200520] */
            ii(0x1016_6b1a, 1); push(eax);                              /* push eax */
            ii(0x1016_6b1b, 3); mov(eax, memd[ds, esi + 0x1c]);         /* mov eax, [esi+0x1c] */
            ii(0x1016_6b1e, 1); dec(eax);                               /* dec eax */
            ii(0x1016_6b1f, 1); push(eax);                              /* push eax */
            ii(0x1016_6b20, 3); mov(eax, memd[ds, esi + 0x18]);         /* mov eax, [esi+0x18] */
            ii(0x1016_6b23, 3); mov(edx, memd[ds, esi + 0x18]);         /* mov edx, [esi+0x18] */
            ii(0x1016_6b26, 1); dec(eax);                               /* dec eax */
            ii(0x1016_6b27, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1016_6b29, 1); push(eax);                              /* push eax */
            ii(0x1016_6b2a, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_6b2c, 3); mov(eax, memd[ds, esi + 0x2c]);         /* mov eax, [esi+0x2c] */
            ii(0x1016_6b2f, 5); call(/* sys */ 0x1016_a68c, 0x3b58);    /* call 0x1016a68c */
            ii(0x1016_6b34, 5); mov(eax, memd[ds, 0x101b_ddc8]);        /* mov eax, [0x101bddc8] */
            ii(0x1016_6b39, 6); mov(al, memb[ds, eax + 0x1020_0520]);   /* mov al, [eax+0x10200520] */
            ii(0x1016_6b3f, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_6b44, 1); push(eax);                              /* push eax */
            ii(0x1016_6b45, 5); mov(eax, memd[ds, 0x101b_ddc4]);        /* mov eax, [0x101bddc4] */
            ii(0x1016_6b4a, 6); mov(al, memb[ds, eax + 0x1020_0520]);   /* mov al, [eax+0x10200520] */
            ii(0x1016_6b50, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_6b55, 1); push(eax);                              /* push eax */
            ii(0x1016_6b56, 3); mov(eax, memd[ds, esi + 0x1c]);         /* mov eax, [esi+0x1c] */
            ii(0x1016_6b59, 3); sub(eax, 2);                            /* sub eax, 0x2 */
            ii(0x1016_6b5c, 1); push(eax);                              /* push eax */
            ii(0x1016_6b5d, 3); mov(eax, memd[ds, esi + 0x18]);         /* mov eax, [esi+0x18] */
            ii(0x1016_6b60, 5); mov(ecx, 1);                            /* mov ecx, 0x1 */
            ii(0x1016_6b65, 3); sub(eax, 2);                            /* sub eax, 0x2 */
            ii(0x1016_6b68, 3); mov(edx, memd[ds, esi + 0x18]);         /* mov edx, [esi+0x18] */
            ii(0x1016_6b6b, 1); push(eax);                              /* push eax */
            ii(0x1016_6b6c, 2); mov(ebx, ecx);                          /* mov ebx, ecx */
            ii(0x1016_6b6e, 3); mov(eax, memd[ds, esi + 0x2c]);         /* mov eax, [esi+0x2c] */
            ii(0x1016_6b71, 5); call(/* sys */ 0x1016_a714, 0x3b9e);    /* call 0x1016a714 */
            ii(0x1016_6b76, 5); mov(eax, memd[ds, 0x101b_ddc4]);        /* mov eax, [0x101bddc4] */
            ii(0x1016_6b7b, 6); mov(al, memb[ds, eax + 0x1020_0520]);   /* mov al, [eax+0x10200520] */
            ii(0x1016_6b81, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_6b86, 1); push(eax);                              /* push eax */
            ii(0x1016_6b87, 5); mov(eax, memd[ds, 0x101b_ddc8]);        /* mov eax, [0x101bddc8] */
            ii(0x1016_6b8c, 6); mov(al, memb[ds, eax + 0x1020_0520]);   /* mov al, [eax+0x10200520] */
            ii(0x1016_6b92, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_6b97, 1); push(eax);                              /* push eax */
            ii(0x1016_6b98, 3); mov(eax, memd[ds, esi + 0x1c]);         /* mov eax, [esi+0x1c] */
            ii(0x1016_6b9b, 3); sub(eax, 6);                            /* sub eax, 0x6 */
            ii(0x1016_6b9e, 1); push(eax);                              /* push eax */
            ii(0x1016_6b9f, 3); mov(eax, memd[ds, esi + 0x18]);         /* mov eax, [esi+0x18] */
            ii(0x1016_6ba2, 5); mov(ecx, 5);                            /* mov ecx, 0x5 */
            ii(0x1016_6ba7, 3); sub(eax, 6);                            /* sub eax, 0x6 */
            ii(0x1016_6baa, 3); mov(edx, memd[ds, esi + 0x18]);         /* mov edx, [esi+0x18] */
            ii(0x1016_6bad, 1); push(eax);                              /* push eax */
            ii(0x1016_6bae, 2); mov(ebx, ecx);                          /* mov ebx, ecx */
            ii(0x1016_6bb0, 3); mov(eax, memd[ds, esi + 0x2c]);         /* mov eax, [esi+0x2c] */
            ii(0x1016_6bb3, 5); call(/* sys */ 0x1016_a714, 0x3b5c);    /* call 0x1016a714 */
        l_0x1016_6bb8:
            ii(0x1016_6bb8, 1); pop(esi);                               /* pop esi */
            ii(0x1016_6bb9, 1); pop(edx);                               /* pop edx */
            ii(0x1016_6bba, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_6bbb, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_6bbc, 1); ret();                                  /* ret */
        }
    }
}
