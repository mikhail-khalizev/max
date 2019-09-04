using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_d93f-2e97a1e2")]
        public void /* sys */ Method_1017_d93f()
        {
            ii(0x1017_d93f, 1); push(edx);                              /* push edx */
            ii(0x1017_d940, 1); push(esi);                              /* push esi */
            ii(0x1017_d941, 1); push(edi);                              /* push edi */
            ii(0x1017_d942, 1); push(ebp);                              /* push ebp */
            ii(0x1017_d943, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_d945, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1017_d94b, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1017_d94e, 4); mov(memw[ss, ebp - 20], cx);            /* mov [ebp-0x14], cx */
            ii(0x1017_d952, 3); mov(memd[ss, ebp - 24], ebx);           /* mov [ebp-0x18], ebx */
            ii(0x1017_d955, 7); mov(memd[ss, ebp - 4], 0);              /* mov dword [ebp-0x4], 0x0 */
        l_0x1017_d95c:
            ii(0x1017_d95c, 4); cmp(memd[ss, ebp - 4], 0x10);           /* cmp dword [ebp-0x4], 0x10 */
            ii(0x1017_d960, 2); if(jb(0x1017_d969, 7)) goto l_0x1017_d969; /* jb 0x1017d969 */
            ii(0x1017_d962, 2); jmp(0x1017_d982, 0x1e); goto l_0x1017_d982; /* jmp 0x1017d982 */
        l_0x1017_d964:
            ii(0x1017_d964, 3); inc(memd[ss, ebp - 4]);                 /* inc dword [ebp-0x4] */
            ii(0x1017_d967, 2); jmp(0x1017_d95c, -0xd); goto l_0x1017_d95c; /* jmp 0x1017d95c */
        l_0x1017_d969:
            ii(0x1017_d969, 4); imul(eax, memd[ss, ebp - 4], 6);        /* imul eax, [ebp-0x4], 0x6 */
            ii(0x1017_d96d, 7); cmp(memd[ds, eax + 0x101c_0699], 0);    /* cmp dword [eax+0x101c0699], 0x0 */
            ii(0x1017_d974, 2); if(jnz(0x1017_d980, 0xa)) goto l_0x1017_d980; /* jnz 0x1017d980 */
            ii(0x1017_d976, 8); cmp(memw[ds, eax + 0x101c_069d], 0);    /* cmp word [eax+0x101c069d], 0x0 */
            ii(0x1017_d97e, 2); if(jz(0x1017_d982, 2)) goto l_0x1017_d982; /* jz 0x1017d982 */
        l_0x1017_d980:
            ii(0x1017_d980, 2); jmp(0x1017_d964, -0x1e); goto l_0x1017_d964; /* jmp 0x1017d964 */
        l_0x1017_d982:
            ii(0x1017_d982, 4); cmp(memd[ss, ebp - 4], 0x10);           /* cmp dword [ebp-0x4], 0x10 */
            ii(0x1017_d986, 2); if(jb(0x1017_d994, 0xc)) goto l_0x1017_d994; /* jb 0x1017d994 */
            ii(0x1017_d988, 7); mov(memd[ss, ebp - 12], 0xb);           /* mov dword [ebp-0xc], 0xb */
            ii(0x1017_d98f, 5); jmp(0x1017_dadf, 0x14b); goto l_0x1017_dadf; /* jmp 0x1017dadf */
        l_0x1017_d994:
            ii(0x1017_d994, 7); cmp(memb[ds, 0x101c_1a54], 0);          /* cmp byte [0x101c1a54], 0x0 */
            ii(0x1017_d99b, 2); if(jz(0x1017_d9a2, 5)) goto l_0x1017_d9a2; /* jz 0x1017d9a2 */
            ii(0x1017_d99d, 5); call(/* sys */ 0x1019_4b45, 0x1_71a3);  /* call 0x10194b45 */
        l_0x1017_d9a2:
            ii(0x1017_d9a2, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1017_d9a5, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1017_d9a8, 4); imul(edx, memd[ss, ebp - 4], 6);        /* imul edx, [ebp-0x4], 0x6 */
            ii(0x1017_d9ac, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1017_d9af, 7); mov(memw[ds, edx + 0x101c_069d], ax);   /* mov [edx+0x101c069d], ax */
            ii(0x1017_d9b6, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1017_d9b9, 6); mov(memd[ds, edx + 0x101c_0699], eax);  /* mov [edx+0x101c0699], eax */
            ii(0x1017_d9bf, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1017_d9c2, 3); shl(edx, 2);                            /* shl edx, 0x2 */
            ii(0x1017_d9c5, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1017_d9c8, 6); mov(memd[ds, edx + 0x101c_06f9], eax);  /* mov [edx+0x101c06f9], eax */
            ii(0x1017_d9ce, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_d9d0, 5); mov(eax, 0x12_34dc);                    /* mov eax, 0x1234dc */
            ii(0x1017_d9d5, 3); div(memd[ss, ebp - 16]);                /* div dword [ebp-0x10] */
            ii(0x1017_d9d8, 6); cmp(eax, memd[ds, 0x101c_0695]);        /* cmp eax, [0x101c0695] */
            ii(0x1017_d9de, 2); if(jae(0x1017_d9ef, 0xf)) goto l_0x1017_d9ef; /* jae 0x1017d9ef */
            ii(0x1017_d9e0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_d9e2, 5); mov(eax, 0x12_34dc);                    /* mov eax, 0x1234dc */
            ii(0x1017_d9e7, 3); div(memd[ss, ebp - 16]);                /* div dword [ebp-0x10] */
            ii(0x1017_d9ea, 5); call(/* sys */ 0x1017_de3a, 0x44b);     /* call 0x1017de3a */
        l_0x1017_d9ef:
            ii(0x1017_d9ef, 7); mov(memd[ss, ebp - 4], 0);              /* mov dword [ebp-0x4], 0x0 */
        l_0x1017_d9f6:
            ii(0x1017_d9f6, 4); cmp(memd[ss, ebp - 4], 0x10);           /* cmp dword [ebp-0x4], 0x10 */
            ii(0x1017_d9fa, 2); if(jb(0x1017_da06, 0xa)) goto l_0x1017_da06; /* jb 0x1017da06 */
            ii(0x1017_d9fc, 5); jmp(0x1017_dac0, 0xbf); goto l_0x1017_dac0; /* jmp 0x1017dac0 */
        l_0x1017_da01:
            ii(0x1017_da01, 3); inc(memd[ss, ebp - 4]);                 /* inc dword [ebp-0x4] */
            ii(0x1017_da04, 2); jmp(0x1017_d9f6, -0x10); goto l_0x1017_d9f6; /* jmp 0x1017d9f6 */
        l_0x1017_da06:
            ii(0x1017_da06, 4); imul(eax, memd[ss, ebp - 4], 6);        /* imul eax, [ebp-0x4], 0x6 */
            ii(0x1017_da0a, 7); cmp(memd[ds, eax + 0x101c_0699], 0);    /* cmp dword [eax+0x101c0699], 0x0 */
            ii(0x1017_da11, 2); if(jnz(0x1017_da21, 0xe)) goto l_0x1017_da21; /* jnz 0x1017da21 */
            ii(0x1017_da13, 8); cmp(memw[ds, eax + 0x101c_069d], 0);    /* cmp word [eax+0x101c069d], 0x0 */
            ii(0x1017_da1b, 6); if(jz(0x1017_dabb, 0x9a)) goto l_0x1017_dabb; /* jz 0x1017dabb */
        l_0x1017_da21:
            ii(0x1017_da21, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1017_da24, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1017_da27, 10); cmp(memd[ds, eax + 0x101c_06f9], 0xff00); /* cmp dword [eax+0x101c06f9], 0xff00 */
            ii(0x1017_da31, 2); if(jnz(0x1017_da79, 0x46)) goto l_0x1017_da79; /* jnz 0x1017da79 */
            ii(0x1017_da33, 10); cmp(memd[ds, 0x101c_0695], 0xffff);    /* cmp dword [0x101c0695], 0xffff */
            ii(0x1017_da3d, 2); if(jnz(0x1017_da51, 0x12)) goto l_0x1017_da51; /* jnz 0x1017da51 */
            ii(0x1017_da3f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1017_da42, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1017_da45, 10); mov(memd[ds, eax + 0x101c_0739], 0x1_0000); /* mov dword [eax+0x101c0739], 0x10000 */
            ii(0x1017_da4f, 2); jmp(0x1017_da77, 0x26); goto l_0x1017_da77; /* jmp 0x1017da77 */
        l_0x1017_da51:
            ii(0x1017_da51, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_da53, 5); mov(eax, 0x12_34dc);                    /* mov eax, 0x1234dc */
            ii(0x1017_da58, 6); div(memd[ds, 0x101c_0695]);             /* div dword [0x101c0695] */
            ii(0x1017_da5e, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_da60, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_da62, 5); mov(eax, 0x12_3333);                    /* mov eax, 0x123333 */
            ii(0x1017_da67, 2); div(ebx);                               /* div ebx */
            ii(0x1017_da69, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_da6b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1017_da6e, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1017_da71, 6); mov(memd[ds, eax + 0x101c_0739], ebx);  /* mov [eax+0x101c0739], ebx */
        l_0x1017_da77:
            ii(0x1017_da77, 2); jmp(0x1017_daab, 0x32); goto l_0x1017_daab; /* jmp 0x1017daab */
        l_0x1017_da79:
            ii(0x1017_da79, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1017_da7c, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1017_da7f, 6); mov(ecx, memd[ds, eax + 0x101c_06f9]);  /* mov ecx, [eax+0x101c06f9] */
            ii(0x1017_da85, 3); shl(ecx, 0x10);                         /* shl ecx, 0x10 */
            ii(0x1017_da88, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_da8a, 5); mov(eax, 0x12_34dc);                    /* mov eax, 0x1234dc */
            ii(0x1017_da8f, 6); div(memd[ds, 0x101c_0695]);             /* div dword [0x101c0695] */
            ii(0x1017_da95, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_da97, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_da99, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1017_da9b, 2); div(ebx);                               /* div ebx */
            ii(0x1017_da9d, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_da9f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1017_daa2, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1017_daa5, 6); mov(memd[ds, eax + 0x101c_0739], ebx);  /* mov [eax+0x101c0739], ebx */
        l_0x1017_daab:
            ii(0x1017_daab, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1017_daae, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1017_dab1, 10); mov(memd[ds, eax + 0x101c_0779], 0);   /* mov dword [eax+0x101c0779], 0x0 */
        l_0x1017_dabb:
            ii(0x1017_dabb, 5); jmp(0x1017_da01, -0xbf); goto l_0x1017_da01; /* jmp 0x1017da01 */
        l_0x1017_dac0:
            ii(0x1017_dac0, 7); cmp(memb[ds, 0x101c_1a54], 0);          /* cmp byte [0x101c1a54], 0x0 */
            ii(0x1017_dac7, 2); if(jz(0x1017_dace, 5)) goto l_0x1017_dace; /* jz 0x1017dace */
            ii(0x1017_dac9, 5); call(/* sys */ 0x1019_4b71, 0x1_70a3);  /* call 0x10194b71 */
        l_0x1017_dace:
            ii(0x1017_dace, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1017_dad1, 4); lgs(edx, memd[ss, ebp + 20]);           /* lgs edx, [ebp+0x14] */
            ii(0x1017_dad5, 3); mov(memd[gs, edx], eax);                /* mov [gs:edx], eax */
            ii(0x1017_dad8, 7); mov(memd[ss, ebp - 12], 0);             /* mov dword [ebp-0xc], 0x0 */
        l_0x1017_dadf:
            ii(0x1017_dadf, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1017_dae2, 1); leave();                                /* leave */
            ii(0x1017_dae3, 1); pop(edi);                               /* pop edi */
            ii(0x1017_dae4, 1); pop(esi);                               /* pop esi */
            ii(0x1017_dae5, 1); pop(edx);                               /* pop edx */
            ii(0x1017_dae6, 3); ret(8);                                 /* ret 0x8 */
        }
    }
}
