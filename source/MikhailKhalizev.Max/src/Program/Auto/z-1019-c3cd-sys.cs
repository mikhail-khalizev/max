using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_c3cd-e294e27b")]
        public void /* sys */ Method_1019_c3cd()
        {
            ii(0x1019_c3cd, 1); push(ebx);                              /* push ebx */
            ii(0x1019_c3ce, 1); push(ecx);                              /* push ecx */
            ii(0x1019_c3cf, 1); push(edx);                              /* push edx */
            ii(0x1019_c3d0, 1); push(esi);                              /* push esi */
            ii(0x1019_c3d1, 1); push(edi);                              /* push edi */
            ii(0x1019_c3d2, 1); pushd(es);                              /* push es */
            ii(0x1019_c3d3, 2); pushd(fs);                              /* push fs */
            ii(0x1019_c3d5, 7); cmp(memd[ds, 0x101c_1cf8], 0);          /* cmp dword [0x101c1cf8], 0x0 */
            ii(0x1019_c3dc, 6); if(jnz(0x1019_c498, 0xb6)) goto l_0x1019_c498; /* jnz 0x1019c498 */
            ii(0x1019_c3e2, 6); mov(fs, memw[ds, 0x101b_e595]);         /* mov fs, [0x101be595] */
            ii(0x1019_c3e8, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1019_c3ea, 2); xor(dl, dl);                            /* xor dl, dl */
            ii(0x1019_c3ec, 2); mov(eax, fs);                           /* mov eax, fs */
            ii(0x1019_c3ee, 6); mov(edi, memd[ds, 0x101b_e591]);        /* mov edi, [0x101be591] */
            ii(0x1019_c3f4, 2); mov(es, eax);                           /* mov es, eax */
            ii(0x1019_c3f6, 2); mov(eax, edi);                          /* mov eax, edi */
        l_0x1019_c3f8:
            ii(0x1019_c3f8, 3); cmp(dl, memb[es, eax]);                 /* cmp dl, [es:eax] */
            ii(0x1019_c3fb, 2); if(jz(0x1019_c410, 0x13)) goto l_0x1019_c410; /* jz 0x1019c410 */
        l_0x1019_c3fd:
            ii(0x1019_c3fd, 3); mov(dh, memb[es, eax]);                 /* mov dh, [es:eax] */
            ii(0x1019_c400, 3); lea(ebx, memd[ds, eax + 1]);            /* lea ebx, [eax+0x1] */
            ii(0x1019_c403, 2); cmp(dl, dh);                            /* cmp dl, dh */
            ii(0x1019_c405, 2); if(jz(0x1019_c40b, 4)) goto l_0x1019_c40b; /* jz 0x1019c40b */
            ii(0x1019_c407, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1019_c409, 2); jmp(0x1019_c3fd, -0xe); goto l_0x1019_c3fd; /* jmp 0x1019c3fd */
        l_0x1019_c40b:
            ii(0x1019_c40b, 1); inc(ecx);                               /* inc ecx */
            ii(0x1019_c40c, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1019_c40e, 2); jmp(0x1019_c3f8, -0x18); goto l_0x1019_c3f8; /* jmp 0x1019c3f8 */
        l_0x1019_c410:
            ii(0x1019_c410, 2); sub(eax, edi);                          /* sub eax, edi */
            ii(0x1019_c412, 2); if(jnz(0x1019_c419, 5)) goto l_0x1019_c419; /* jnz 0x1019c419 */
            ii(0x1019_c414, 5); mov(eax, 1);                            /* mov eax, 0x1 */
        l_0x1019_c419:
            ii(0x1019_c419, 5); call(Definitions.sys_malloc, -0x3_1440); /* call 0x1016afde */
            ii(0x1019_c41e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1019_c420, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1019_c422, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1019_c424, 6); if(jz(0x1019_c498, 0x6e)) goto l_0x1019_c498; /* jz 0x1019c498 */
            ii(0x1019_c42a, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1019_c42c, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1019_c42f, 3); add(eax, 4);                            /* add eax, 0x4 */
            ii(0x1019_c432, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1019_c434, 5); call(Definitions.sys_malloc, -0x3_145b); /* call 0x1016afde */
            ii(0x1019_c439, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1019_c43b, 2); if(jz(0x1019_c491, 0x54)) goto l_0x1019_c491; /* jz 0x1019c491 */
            ii(0x1019_c43d, 5); mov(memd[ds, 0x101c_1cf8], eax);        /* mov [0x101c1cf8], eax */
            ii(0x1019_c442, 2); xor(esi, esi);                          /* xor esi, esi */
            ii(0x1019_c444, 2); mov(eax, fs);                           /* mov eax, fs */
            ii(0x1019_c446, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1019_c448, 2); mov(es, eax);                           /* mov es, eax */
            ii(0x1019_c44a, 2); mov(eax, edi);                          /* mov eax, edi */
        l_0x1019_c44c:
            ii(0x1019_c44c, 4); cmp(memb[es, eax], 0);                  /* cmp byte [es:eax], 0x0 */
            ii(0x1019_c450, 2); if(jz(0x1019_c46c, 0x1a)) goto l_0x1019_c46c; /* jz 0x1019c46c */
            ii(0x1019_c452, 6); mov(edx, memd[ds, 0x101c_1cf8]);        /* mov edx, [0x101c1cf8] */
            ii(0x1019_c458, 3); mov(memd[ds, ecx + edx], ebx);          /* mov [ecx+edx], ebx */
        l_0x1019_c45b:
            ii(0x1019_c45b, 3); mov(dl, memb[es, eax]);                 /* mov dl, [es:eax] */
            ii(0x1019_c45e, 1); inc(eax);                               /* inc eax */
            ii(0x1019_c45f, 2); mov(memb[ds, ebx], dl);                 /* mov [ebx], dl */
            ii(0x1019_c461, 1); inc(ebx);                               /* inc ebx */
            ii(0x1019_c462, 2); test(dl, dl);                           /* test dl, dl */
            ii(0x1019_c464, 2); if(jnz(0x1019_c45b, -0xb)) goto l_0x1019_c45b; /* jnz 0x1019c45b */
            ii(0x1019_c466, 3); add(ecx, 4);                            /* add ecx, 0x4 */
            ii(0x1019_c469, 1); inc(esi);                               /* inc esi */
            ii(0x1019_c46a, 2); jmp(0x1019_c44c, -0x20); goto l_0x1019_c44c; /* jmp 0x1019c44c */
        l_0x1019_c46c:
            ii(0x1019_c46c, 6); mov(edx, memd[ds, 0x101c_1cf8]);        /* mov edx, [0x101c1cf8] */
            ii(0x1019_c472, 7); mov(memd[ds, ecx + edx], 0);            /* mov dword [ecx+edx], 0x0 */
            ii(0x1019_c479, 3); add(ecx, 4);                            /* add ecx, 0x4 */
            ii(0x1019_c47c, 2); add(edx, ecx);                          /* add edx, ecx */
            ii(0x1019_c47e, 2); mov(ebx, esi);                          /* mov ebx, esi */
            ii(0x1019_c480, 6); mov(memd[ds, 0x101c_1cfc], edx);        /* mov [0x101c1cfc], edx */
            ii(0x1019_c486, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1019_c488, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1019_c48a, 5); call(Definitions.sys_memset, -0x3_66af); /* call 0x10165de0 */
            ii(0x1019_c48f, 2); jmp(0x1019_c498, 7); goto l_0x1019_c498; /* jmp 0x1019c498 */
        l_0x1019_c491:
            ii(0x1019_c491, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1019_c493, 5); call(Definitions.sys_free, -0x3_13d7);  /* call 0x1016b0c1 */
        l_0x1019_c498:
            ii(0x1019_c498, 2); popd(fs);                               /* pop fs */
            ii(0x1019_c49a, 1); popd(es);                               /* pop es */
            ii(0x1019_c49b, 1); pop(edi);                               /* pop edi */
            ii(0x1019_c49c, 1); pop(esi);                               /* pop esi */
            ii(0x1019_c49d, 1); pop(edx);                               /* pop edx */
            ii(0x1019_c49e, 1); pop(ecx);                               /* pop ecx */
            ii(0x1019_c49f, 1); pop(ebx);                               /* pop ebx */
            ii(0x1019_c4a0, 1); ret();                                  /* ret */
        }
    }
}
