using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_ba3c-784afcd1")]
        public void /* sys */ Method_1016_ba3c()
        {
            ii(0x1016_ba3c, 1); push(esi);                              /* push esi */
            ii(0x1016_ba3d, 1); push(edi);                              /* push edi */
            ii(0x1016_ba3e, 1); push(ebp);                              /* push ebp */
            ii(0x1016_ba3f, 3); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1016_ba42, 4); mov(edi, memd[ss, esp + 40]);           /* mov edi, [esp+0x28] */
            ii(0x1016_ba46, 4); mov(ebp, memd[ss, esp + 44]);           /* mov ebp, [esp+0x2c] */
            ii(0x1016_ba4a, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1016_ba4c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_ba4e, 2); if(jnz(0x1016_ba72, 0x22)) goto l_0x1016_ba72; /* jnz 0x1016ba72 */
            ii(0x1016_ba50, 5); mov(esi, 0x101b_de20);                  /* mov esi, 0x101bde20 */
            ii(0x1016_ba55, 5); mov(edx, 8);                            /* mov edx, 0x8 */
            ii(0x1016_ba5a, 5); mov(edi, 1);                            /* mov edi, 0x1 */
            ii(0x1016_ba5f, 5); mov(al, memb[ds, 0x1020_0520]);         /* mov al, [0x10200520] */
        l_0x1016_ba64:
            ii(0x1016_ba64, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1016_ba66, 2); mov(ecx, edx);                          /* mov ecx, edx */
            ii(0x1016_ba68, 2); mov(ebp, edi);                          /* mov ebp, edi */
            ii(0x1016_ba6a, 4); mov(memb[ss, esp + 48], al);            /* mov [esp+0x30], al */
            ii(0x1016_ba6e, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1016_ba70, 2); if(jz(0x1016_ba64, -0xe)) goto l_0x1016_ba64; /* jz 0x1016ba64 */
        l_0x1016_ba72:
            ii(0x1016_ba72, 5); mov(eax, memd[ds, 0x101c_fb90]);        /* mov eax, [0x101cfb90] */
            ii(0x1016_ba77, 4); mov(memd[ss, esp + 20], eax);           /* mov [esp+0x14], eax */
            ii(0x1016_ba7b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_ba7d, 2); if(jnz(0x1016_baa7, 0x28)) goto l_0x1016_baa7; /* jnz 0x1016baa7 */
            ii(0x1016_ba7f, 7); cmp(memd[ds, 0x101c_fbe8], 0);          /* cmp dword [0x101cfbe8], 0x0 */
            ii(0x1016_ba86, 2); if(jz(0x1016_baa7, 0x1f)) goto l_0x1016_baa7; /* jz 0x1016baa7 */
            ii(0x1016_ba88, 5); cmp(memd[ss, esp + 20], 0);             /* cmp dword [esp+0x14], 0x0 */
            ii(0x1016_ba8d, 2); if(jnz(0x1016_baa7, 0x18)) goto l_0x1016_baa7; /* jnz 0x1016baa7 */
            ii(0x1016_ba8f, 10); mov(memd[ds, 0x101c_fb90], 1);         /* mov dword [0x101cfb90], 0x1 */
            ii(0x1016_ba99, 2); mov(eax, esp);                          /* mov eax, esp */
            ii(0x1016_ba9b, 5); call(/* sys */ 0x1016_c25c, 0x7bc);     /* call 0x1016c25c */
            ii(0x1016_baa0, 2); mov(eax, esp);                          /* mov eax, esp */
            ii(0x1016_baa2, 5); call(/* sys */ 0x1016_7ac0, -0x3fe7);   /* call 0x10167ac0 */
        l_0x1016_baa7:
            ii(0x1016_baa7, 6); cmp(edx, memd[ds, 0x101c_fbf0]);        /* cmp edx, [0x101cfbf0] */
            ii(0x1016_baad, 2); if(jnz(0x1016_bab7, 8)) goto l_0x1016_bab7; /* jnz 0x1016bab7 */
            ii(0x1016_baaf, 6); cmp(ebx, memd[ds, 0x101c_fb94]);        /* cmp ebx, [0x101cfb94] */
            ii(0x1016_bab5, 2); if(jz(0x1016_baf6, 0x3f)) goto l_0x1016_baf6; /* jz 0x1016baf6 */
        l_0x1016_bab7:
            ii(0x1016_bab7, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_bab9, 3); imul(eax, ebx);                         /* imul eax, ebx */
            ii(0x1016_babc, 5); call(Definitions.sys_malloc_internal, 0x1_682f); /* call 0x101822f0 */
            ii(0x1016_bac1, 4); mov(memd[ss, esp + 16], eax);           /* mov [esp+0x10], eax */
            ii(0x1016_bac5, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_bac7, 2); if(jnz(0x1016_badf, 0x16)) goto l_0x1016_badf; /* jnz 0x1016badf */
            ii(0x1016_bac9, 5); cmp(memd[ss, esp + 20], 0);             /* cmp dword [esp+0x14], 0x0 */
            ii(0x1016_bace, 2); if(jnz(0x1016_bad5, 5)) goto l_0x1016_bad5; /* jnz 0x1016bad5 */
            ii(0x1016_bad0, 5); call(/* sys */ 0x1016_bcc4, 0x1ef);     /* call 0x1016bcc4 */
        l_0x1016_bad5:
            ii(0x1016_bad5, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1016_bada, 5); jmp(0x1016_bb7d, 0x9e); goto l_0x1016_bb7d; /* jmp 0x1016bb7d */
        l_0x1016_badf:
            ii(0x1016_badf, 5); mov(eax, memd[ds, 0x101b_de60]);        /* mov eax, [0x101bde60] */
            ii(0x1016_bae4, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_bae6, 2); if(jz(0x1016_baed, 5)) goto l_0x1016_baed; /* jz 0x1016baed */
            ii(0x1016_bae8, 5); call(Definitions.sys_free_internal, 0x1_6967); /* call 0x10182454 */
        l_0x1016_baed:
            ii(0x1016_baed, 4); mov(eax, memd[ss, esp + 16]);           /* mov eax, [esp+0x10] */
            ii(0x1016_baf1, 5); mov(memd[ds, 0x101b_de60], eax);        /* mov [0x101bde60], eax */
        l_0x1016_baf6:
            ii(0x1016_baf6, 4); mov(al, memb[ss, esp + 48]);            /* mov al, [esp+0x30] */
            ii(0x1016_bafa, 6); mov(memd[ds, 0x101b_de64], esi);        /* mov [0x101bde64], esi */
            ii(0x1016_bb00, 6); mov(memd[ds, 0x101c_fbf0], edx);        /* mov [0x101cfbf0], edx */
            ii(0x1016_bb06, 6); mov(memd[ds, 0x101c_fb94], ebx);        /* mov [0x101cfb94], ebx */
            ii(0x1016_bb0c, 6); mov(memd[ds, 0x101c_fbec], ecx);        /* mov [0x101cfbec], ecx */
            ii(0x1016_bb12, 6); mov(edx, memd[ds, 0x101b_de68]);        /* mov edx, [0x101bde68] */
            ii(0x1016_bb18, 5); mov(memb[ds, 0x101c_fc04], al);         /* mov [0x101cfc04], al */
            ii(0x1016_bb1d, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1016_bb1f, 2); if(jz(0x1016_bb2b, 0xa)) goto l_0x1016_bb2b; /* jz 0x1016bb2b */
            ii(0x1016_bb21, 5); mov(eax, /* sys */ 0x1016_bc4c);        /* mov eax, 0x1016bc4c */
            ii(0x1016_bb26, 5); call(/* sys */ 0x1016_b42c, -0x6ff);    /* call 0x1016b42c */
        l_0x1016_bb2b:
            ii(0x1016_bb2b, 5); mov(eax, memd[ds, 0x101c_fbfc]);        /* mov eax, [0x101cfbfc] */
            ii(0x1016_bb30, 6); mov(ecx, memd[ds, 0x101c_fbd4]);        /* mov ecx, [0x101cfbd4] */
            ii(0x1016_bb36, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_bb38, 6); mov(esi, memd[ds, 0x101c_fbd0]);        /* mov esi, [0x101cfbd0] */
            ii(0x1016_bb3e, 6); mov(memd[ds, 0x101b_de68], ebx);        /* mov [0x101bde68], ebx */
            ii(0x1016_bb44, 2); sub(eax, edi);                          /* sub eax, edi */
            ii(0x1016_bb46, 6); mov(memd[ds, 0x101c_fbfc], edi);        /* mov [0x101cfbfc], edi */
            ii(0x1016_bb4c, 2); add(ecx, eax);                          /* add ecx, eax */
            ii(0x1016_bb4e, 5); mov(eax, memd[ds, 0x101c_fbf8]);        /* mov eax, [0x101cfbf8] */
            ii(0x1016_bb53, 4); mov(edi, memd[ss, esp + 20]);           /* mov edi, [esp+0x14] */
            ii(0x1016_bb57, 2); sub(eax, ebp);                          /* sub eax, ebp */
            ii(0x1016_bb59, 6); mov(memd[ds, 0x101c_fbd4], ecx);        /* mov [0x101cfbd4], ecx */
            ii(0x1016_bb5f, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x1016_bb61, 6); mov(memd[ds, 0x101c_fbf8], ebp);        /* mov [0x101cfbf8], ebp */
            ii(0x1016_bb67, 6); mov(memd[ds, 0x101c_fbd0], esi);        /* mov [0x101cfbd0], esi */
            ii(0x1016_bb6d, 5); call(/* sys */ 0x1016_c2e0, 0x76e);     /* call 0x1016c2e0 */
            ii(0x1016_bb72, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1016_bb74, 2); if(jnz(0x1016_bb7b, 5)) goto l_0x1016_bb7b; /* jnz 0x1016bb7b */
            ii(0x1016_bb76, 5); call(/* sys */ 0x1016_bcc4, 0x149);     /* call 0x1016bcc4 */
        l_0x1016_bb7b:
            ii(0x1016_bb7b, 2); xor(eax, eax);                          /* xor eax, eax */
        l_0x1016_bb7d:
            ii(0x1016_bb7d, 3); add(esp, 0x18);                         /* add esp, 0x18 */
            ii(0x1016_bb80, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_bb81, 1); pop(edi);                               /* pop edi */
            ii(0x1016_bb82, 1); pop(esi);                               /* pop esi */
            ii(0x1016_bb83, 3); ret(0xc);                               /* ret 0xc */
        }
    }
}
