using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_a8e8-3c6ddb86")]
        public void /* sys */ Method_1019_a8e8()
        {
            ii(0x1019_a8e8, 1); push(ebx);                              /* push ebx */
            ii(0x1019_a8e9, 1); push(ecx);                              /* push ecx */
            ii(0x1019_a8ea, 1); push(edx);                              /* push edx */
            ii(0x1019_a8eb, 1); push(esi);                              /* push esi */
            ii(0x1019_a8ec, 1); push(edi);                              /* push edi */
            ii(0x1019_a8ed, 1); pushd(es);                              /* push es */
            ii(0x1019_a8ee, 1); push(ebp);                              /* push ebp */
            ii(0x1019_a8ef, 1); push(eax);                              /* push eax */
            ii(0x1019_a8f0, 6); cmp(eax, memd[ds, 0x101b_e574]);        /* cmp eax, [0x101be574] */
            ii(0x1019_a8f6, 2); if(jb(0x1019_a953, 0x5b)) goto l_0x1019_a953; /* jb 0x1019a953 */
            ii(0x1019_a8f8, 7); cmp(memb[ds, 0x101b_e58e], 0);          /* cmp byte [0x101be58e], 0x0 */
            ii(0x1019_a8ff, 2); if(jnz(0x1019_a965, 0x64)) goto l_0x1019_a965; /* jnz 0x1019a965 */
            ii(0x1019_a901, 3); mov(ebp, memd[ss, esp]);                /* mov ebp, [esp] */
            ii(0x1019_a904, 3); add(ebp, 0xf);                          /* add ebp, 0xf */
            ii(0x1019_a907, 3); shr(ebp, 0x4);                          /* shr ebp, 0x4 */
            ii(0x1019_a90a, 2); test(ebp, ebp);                         /* test ebp, ebp */
            ii(0x1019_a90c, 2); if(jnz(0x1019_a913, 0x5)) goto l_0x1019_a913; /* jnz 0x1019a913 */
            ii(0x1019_a90e, 5); mov(ebp, 0xfff_ffff);                   /* mov ebp, 0xfffffff */
        l_0x1019_a913:
            ii(0x1019_a913, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1019_a915, 3); mov(ax, ds);                            /* mov ax, ds */
            ii(0x1019_a918, 3); mov(bx, ax);                            /* mov bx, ax */
            ii(0x1019_a91b, 2); mov(ah, 0xed);                          /* mov ah, 0xed */
            ii(0x1019_a91d, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1019_a91f, 3); shl(eax, 0x1f);                         /* shl eax, 0x1f */
            ii(0x1019_a922, 6); and(edi, 0xffff);                       /* and edi, 0xffff */
            ii(0x1019_a928, 2); or(edi, eax);                           /* or edi, eax */
            ii(0x1019_a92a, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1019_a92c, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1019_a92e, 2); if(jge(0x1019_a940, 0x10)) goto l_0x1019_a940; /* jge 0x1019a940 */
            ii(0x1019_a930, 2); mov(ebx, ebp);                          /* mov ebx, ebp */
            ii(0x1019_a932, 2); mov(es, edi);                           /* mov es, edi */
            ii(0x1019_a934, 2); mov(ah, 0x4a);                          /* mov ah, 0x4a */
            ii(0x1019_a936, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1019_a938, 2); rcl(eax, 0x1);                          /* rcl eax, 1 */
            ii(0x1019_a93a, 2); ror(eax, 0x1);                          /* ror eax, 1 */
            ii(0x1019_a93c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1019_a93e, 2); if(jl(0x1019_a953, 0x13)) goto l_0x1019_a953; /* jl 0x1019a953 */
        l_0x1019_a940:
            ii(0x1019_a940, 3); mov(ax, ds);                            /* mov ax, ds */
            ii(0x1019_a943, 2); mov(ebx, ebp);                          /* mov ebx, ebp */
        l_0x1019_a945:
            ii(0x1019_a945, 2); mov(es, eax);                           /* mov es, eax */
            ii(0x1019_a947, 2); mov(ah, 0x4a);                          /* mov ah, 0x4a */
            ii(0x1019_a949, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1019_a94b, 2); rcl(eax, 0x1);                          /* rcl eax, 1 */
            ii(0x1019_a94d, 2); ror(eax, 0x1);                          /* ror eax, 1 */
            ii(0x1019_a94f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1019_a951, 2); if(jge(0x1019_a99a, 0x47)) goto l_0x1019_a99a; /* jge 0x1019a99a */
        l_0x1019_a953:
            ii(0x1019_a953, 5); call(/* sys */ 0x1018_d7a2, -0xd1b6);   /* call 0x1018d7a2 */
            ii(0x1019_a958, 6); mov(memd[ds, eax], 0x5);                /* mov dword [eax], 0x5 */
            ii(0x1019_a95e, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1019_a963, 2); jmp(0x1019_a9a8, 0x43); goto l_0x1019_a9a8; /* jmp 0x1019a9a8 */
        l_0x1019_a965:
            ii(0x1019_a965, 3); mov(ebx, memd[ss, esp]);                /* mov ebx, [esp] */
            ii(0x1019_a968, 6); add(ebx, 0xfff);                        /* add ebx, 0xfff */
            ii(0x1019_a96e, 3); shr(ebx, 0xc);                          /* shr ebx, 0xc */
            ii(0x1019_a971, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1019_a973, 2); if(jnz(0x1019_a97a, 0x5)) goto l_0x1019_a97a; /* jnz 0x1019a97a */
            ii(0x1019_a975, 5); mov(ebx, 0xf_ffff);                     /* mov ebx, 0xfffff */
        l_0x1019_a97a:
            ii(0x1019_a97a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1019_a97c, 5); mov(al, memb[ds, 0x101b_e58e]);         /* mov al, [0x101be58e] */
            ii(0x1019_a981, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1019_a984, 2); if(jnz(0x1019_a995, 0xf)) goto l_0x1019_a995; /* jnz 0x1019a995 */
            ii(0x1019_a986, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1019_a988, 5); mov(al, memb[ds, 0x101b_e58f]);         /* mov al, [0x101be58f] */
            ii(0x1019_a98d, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1019_a990, 2); if(jnz(0x1019_a995, 0x3)) goto l_0x1019_a995; /* jnz 0x1019a995 */
            ii(0x1019_a992, 3); shl(ebx, 0x8);                          /* shl ebx, 0x8 */
        l_0x1019_a995:
            ii(0x1019_a995, 3); mov(ax, ds);                            /* mov ax, ds */
            ii(0x1019_a998, 2); jmp(0x1019_a945, -0x55); goto l_0x1019_a945; /* jmp 0x1019a945 */
        l_0x1019_a99a:
            ii(0x1019_a99a, 3); mov(ebx, memd[ss, esp]);                /* mov ebx, [esp] */
            ii(0x1019_a99d, 5); mov(eax, memd[ds, 0x101b_e560]);        /* mov eax, [0x101be560] */
            ii(0x1019_a9a2, 6); mov(memd[ds, 0x101b_e560], ebx);        /* mov [0x101be560], ebx */
        l_0x1019_a9a8:
            ii(0x1019_a9a8, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1019_a9ab, 1); pop(ebp);                               /* pop ebp */
            ii(0x1019_a9ac, 1); popd(es);                               /* pop es */
            ii(0x1019_a9ad, 1); pop(edi);                               /* pop edi */
            ii(0x1019_a9ae, 1); pop(esi);                               /* pop esi */
            ii(0x1019_a9af, 1); pop(edx);                               /* pop edx */
            ii(0x1019_a9b0, 1); pop(ecx);                               /* pop ecx */
            ii(0x1019_a9b1, 1); pop(ebx);                               /* pop ebx */
            ii(0x1019_a9b2, 1); ret();                                  /* ret */
        }
    }
}
