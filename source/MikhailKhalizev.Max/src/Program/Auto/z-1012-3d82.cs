using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_3d82-23656202")]
        public void Method_1012_3d82()
        {
            ii(0x1012_3d82, 5); push(0x50);                             /* push 0x50 */
            ii(0x1012_3d87, 5); call(Definitions.sys_check_available_stack_size, 0x4_1fc6); /* call 0x10165d52 */
            ii(0x1012_3d8c, 1); push(ebx);                              /* push ebx */
            ii(0x1012_3d8d, 1); push(esi);                              /* push esi */
            ii(0x1012_3d8e, 1); push(edi);                              /* push edi */
            ii(0x1012_3d8f, 1); push(ebp);                              /* push ebp */
            ii(0x1012_3d90, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_3d92, 6); sub(esp, 0x3c);                         /* sub esp, 0x3c */
            ii(0x1012_3d98, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_3d9b, 7); cmp(memd[ds, eax + 0xa0], 0);           /* cmp dword [eax+0xa0], 0x0 */
            ii(0x1012_3da2, 2); if(jnz(0x1012_3db0, 0xc)) goto l_0x1012_3db0; /* jnz 0x10123db0 */
            ii(0x1012_3da4, 7); mov(memd[ss, ebp - 0x14], 0);           /* mov dword [ebp-0x14], 0x0 */
            ii(0x1012_3dab, 5); jmp(0x1012_3f29, 0x179); goto l_0x1012_3f29; /* jmp 0x10123f29 */
        l_0x1012_3db0:
            ii(0x1012_3db0, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_3db3, 6); mov(eax, memd[ds, eax + 0xa0]);         /* mov eax, [eax+0xa0] */
            ii(0x1012_3db9, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
        l_0x1012_3dbc:
            ii(0x1012_3dbc, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1012_3dbf, 3); cmp(memb[ds, eax], 0x20);               /* cmp byte [eax], 0x20 */
            ii(0x1012_3dc2, 2); if(jnz(0x1012_3dcc, 0x8)) goto l_0x1012_3dcc; /* jnz 0x10123dcc */
            ii(0x1012_3dc4, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1012_3dc7, 3); inc(memd[ss, ebp - 0x18]);              /* inc dword [ebp-0x18] */
            ii(0x1012_3dca, 2); jmp(0x1012_3dbc, -0x10); goto l_0x1012_3dbc; /* jmp 0x10123dbc */
        l_0x1012_3dcc:
            ii(0x1012_3dcc, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1012_3dcf, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1012_3dd2, 7); mov(memd[ss, ebp - 0xc], 0);            /* mov dword [ebp-0xc], 0x0 */
        l_0x1012_3dd9:
            ii(0x1012_3dd9, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1012_3ddc, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1012_3dde, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_3de3, 3); cmp(eax, 0xd);                          /* cmp eax, 0xd */
            ii(0x1012_3de6, 2); if(jz(0x1012_3dfc, 0x14)) goto l_0x1012_3dfc; /* jz 0x10123dfc */
            ii(0x1012_3de8, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1012_3deb, 3); inc(memd[ss, ebp - 0x18]);              /* inc dword [ebp-0x18] */
            ii(0x1012_3dee, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1012_3df1, 3); inc(memd[ss, ebp - 0xc]);               /* inc dword [ebp-0xc] */
            ii(0x1012_3df4, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1012_3df6, 4); mov(memb[ds, edx + ebp - 0x3c], al);    /* mov [edx+ebp-0x3c], al */
            ii(0x1012_3dfa, 2); jmp(0x1012_3dd9, -0x23); goto l_0x1012_3dd9; /* jmp 0x10123dd9 */
        l_0x1012_3dfc:
            ii(0x1012_3dfc, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1012_3dff, 5); mov(memb[ds, eax + ebp - 0x3c], 0);     /* mov byte [eax+ebp-0x3c], 0x0 */
            ii(0x1012_3e04, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_3e06, 3); mov(al, memb[ss, ebp - 0x3b]);          /* mov al, [ebp-0x3b] */
            ii(0x1012_3e09, 3); cmp(eax, 0x78);                         /* cmp eax, 0x78 */
            ii(0x1012_3e0c, 2); if(jnz(0x1012_3e20, 0x12)) goto l_0x1012_3e20; /* jnz 0x10123e20 */
            ii(0x1012_3e0e, 5); mov(ebx, 0x10);                         /* mov ebx, 0x10 */
            ii(0x1012_3e13, 3); lea(edx, memd[ss, ebp - 0x3a]);         /* lea edx, [ebp-0x3a] */
            ii(0x1012_3e16, 3); mov(eax, memd[ss, ebp + 0x18]);         /* mov eax, [ebp+0x18] */
            ii(0x1012_3e19, 5); call(/* sys */ 0x1017_93f8, 0x5_55da);  /* call 0x101793f8 */
            ii(0x1012_3e1e, 2); jmp(0x1012_3e30, 0x10); goto l_0x1012_3e30; /* jmp 0x10123e30 */
        l_0x1012_3e20:
            ii(0x1012_3e20, 5); mov(ebx, 0xa);                          /* mov ebx, 0xa */
            ii(0x1012_3e25, 3); lea(edx, memd[ss, ebp - 0x3c]);         /* lea edx, [ebp-0x3c] */
            ii(0x1012_3e28, 3); mov(eax, memd[ss, ebp + 0x18]);         /* mov eax, [ebp+0x18] */
            ii(0x1012_3e2b, 5); call(/* sys */ 0x1017_93f8, 0x5_55c8);  /* call 0x101793f8 */
        l_0x1012_3e30:
            ii(0x1012_3e30, 3); lea(eax, memd[ss, ebp - 0x3c]);         /* lea eax, [ebp-0x3c] */
            ii(0x1012_3e33, 5); call(Definitions.sys_strlen, 0x4_e08f); /* call 0x10171ec7 */
            ii(0x1012_3e38, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1012_3e3b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_3e3e, 3); cmp(eax, memd[ss, ebp - 0xc]);          /* cmp eax, [ebp-0xc] */
            ii(0x1012_3e41, 2); if(jae(0x1012_3e88, 0x45)) goto l_0x1012_3e88; /* jae 0x10123e88 */
            ii(0x1012_3e43, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_3e46, 6); mov(edx, memd[ds, eax + 0x84]);         /* mov edx, [eax+0x84] */
            ii(0x1012_3e4c, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_3e4f, 6); add(edx, memd[ds, eax + 0x88]);         /* add edx, [eax+0x88] */
            ii(0x1012_3e55, 3); sub(edx, memd[ss, ebp - 0x1c]);         /* sub edx, [ebp-0x1c] */
            ii(0x1012_3e58, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1012_3e5b, 3); sub(eax, memd[ss, ebp - 0x8]);          /* sub eax, [ebp-0x8] */
            ii(0x1012_3e5e, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1012_3e60, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1012_3e63, 3); mov(ebx, memd[ss, ebp - 0x4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1012_3e66, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1012_3e69, 3); sub(edx, memd[ss, ebp - 0x8]);          /* sub edx, [ebp-0x8] */
            ii(0x1012_3e6c, 3); add(edx, memd[ss, ebp - 0x1c]);         /* add edx, [ebp-0x1c] */
            ii(0x1012_3e6f, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1012_3e72, 5); call(/* sys */ 0x1016_6177, 0x4_2300);  /* call 0x10166177 */
            ii(0x1012_3e77, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1012_3e7a, 3); sub(edx, memd[ss, ebp - 0x8]);          /* sub edx, [ebp-0x8] */
            ii(0x1012_3e7d, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_3e80, 6); sub(memd[ds, eax + 0x88], edx);         /* sub [eax+0x88], edx */
            ii(0x1012_3e86, 2); jmp(0x1012_3ef6, 0x6e); goto l_0x1012_3ef6; /* jmp 0x10123ef6 */
        l_0x1012_3e88:
            ii(0x1012_3e88, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_3e8b, 3); cmp(eax, memd[ss, ebp - 0xc]);          /* cmp eax, [ebp-0xc] */
            ii(0x1012_3e8e, 2); if(jbe(0x1012_3ef6, 0x66)) goto l_0x1012_3ef6; /* jbe 0x10123ef6 */
            ii(0x1012_3e90, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1012_3e93, 3); sub(edx, memd[ss, ebp - 0xc]);          /* sub edx, [ebp-0xc] */
            ii(0x1012_3e96, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_3e99, 6); add(edx, memd[ds, eax + 0x88]);         /* add edx, [eax+0x88] */
            ii(0x1012_3e9f, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_3ea2, 6); cmp(edx, memd[ds, eax + 0x8c]);         /* cmp edx, [eax+0x8c] */
            ii(0x1012_3ea8, 2); if(jbe(0x1012_3eb3, 0x9)) goto l_0x1012_3eb3; /* jbe 0x10123eb3 */
            ii(0x1012_3eaa, 7); mov(memd[ss, ebp - 0x14], 0);           /* mov dword [ebp-0x14], 0x0 */
            ii(0x1012_3eb1, 2); jmp(0x1012_3f29, 0x76); goto l_0x1012_3f29; /* jmp 0x10123f29 */
        l_0x1012_3eb3:
            ii(0x1012_3eb3, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_3eb6, 6); mov(edx, memd[ds, eax + 0x84]);         /* mov edx, [eax+0x84] */
            ii(0x1012_3ebc, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_3ebf, 6); add(edx, memd[ds, eax + 0x88]);         /* add edx, [eax+0x88] */
            ii(0x1012_3ec5, 3); sub(edx, memd[ss, ebp - 0x1c]);         /* sub edx, [ebp-0x1c] */
            ii(0x1012_3ec8, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_3ecb, 3); sub(eax, memd[ss, ebp - 0xc]);          /* sub eax, [ebp-0xc] */
            ii(0x1012_3ece, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1012_3ed0, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1012_3ed3, 3); mov(ebx, memd[ss, ebp - 0x4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1012_3ed6, 3); mov(edx, memd[ss, ebp - 0x1c]);         /* mov edx, [ebp-0x1c] */
            ii(0x1012_3ed9, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_3edc, 3); sub(eax, memd[ss, ebp - 0xc]);          /* sub eax, [ebp-0xc] */
            ii(0x1012_3edf, 3); add(eax, memd[ss, ebp - 0x1c]);         /* add eax, [ebp-0x1c] */
            ii(0x1012_3ee2, 5); call(/* sys */ 0x1016_6177, 0x4_2290);  /* call 0x10166177 */
            ii(0x1012_3ee7, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1012_3eea, 3); sub(edx, memd[ss, ebp - 0xc]);          /* sub edx, [ebp-0xc] */
            ii(0x1012_3eed, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_3ef0, 6); add(memd[ds, eax + 0x88], edx);         /* add [eax+0x88], edx */
        l_0x1012_3ef6:
            ii(0x1012_3ef6, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
        l_0x1012_3efd:
            ii(0x1012_3efd, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_3f00, 5); cmp(memb[ds, eax + ebp - 0x3c], 0);     /* cmp byte [eax+ebp-0x3c], 0x0 */
            ii(0x1012_3f05, 2); if(jz(0x1012_3f1b, 0x14)) goto l_0x1012_3f1b; /* jz 0x10123f1b */
            ii(0x1012_3f07, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_3f0a, 3); inc(memd[ss, ebp - 0x10]);              /* inc dword [ebp-0x10] */
            ii(0x1012_3f0d, 3); mov(edx, memd[ss, ebp - 0x1c]);         /* mov edx, [ebp-0x1c] */
            ii(0x1012_3f10, 3); inc(memd[ss, ebp - 0x1c]);              /* inc dword [ebp-0x1c] */
            ii(0x1012_3f13, 4); mov(al, memb[ds, eax + ebp - 0x3c]);    /* mov al, [eax+ebp-0x3c] */
            ii(0x1012_3f17, 2); mov(memb[ds, edx], al);                 /* mov [edx], al */
            ii(0x1012_3f19, 2); jmp(0x1012_3efd, -0x1e); goto l_0x1012_3efd; /* jmp 0x10123efd */
        l_0x1012_3f1b:
            ii(0x1012_3f1b, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_3f1e, 4); or(memb[ds, eax + 0x1], -0x80 /* 0x80 */); /* or byte [eax+0x1], 0x80 */
            ii(0x1012_3f22, 7); mov(memd[ss, ebp - 0x14], 0x1);         /* mov dword [ebp-0x14], 0x1 */
        l_0x1012_3f29:
            ii(0x1012_3f29, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1012_3f2c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_3f2e, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_3f2f, 1); pop(edi);                               /* pop edi */
            ii(0x1012_3f30, 1); pop(esi);                               /* pop esi */
            ii(0x1012_3f31, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_3f32, 1); ret();                                  /* ret */
        }
    }
}
