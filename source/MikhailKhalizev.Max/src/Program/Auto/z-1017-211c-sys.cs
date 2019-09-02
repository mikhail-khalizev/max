using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_211c-f4ea5e96")]
        public void /* sys */ Method_1017_211c()
        {
            ii(0x1017_211c, 1); push(ebx);                              /* push ebx */
            ii(0x1017_211d, 1); push(ecx);                              /* push ecx */
            ii(0x1017_211e, 1); push(esi);                              /* push esi */
            ii(0x1017_211f, 1); push(edi);                              /* push edi */
            ii(0x1017_2120, 1); push(ebp);                              /* push ebp */
            ii(0x1017_2121, 3); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1017_2124, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1017_2126, 2); mov(edi, edx);                          /* mov edi, edx */
            ii(0x1017_2128, 4); cmp(memd[ds, eax + 0xc], 0);            /* cmp dword [eax+0xc], 0x0 */
            ii(0x1017_212c, 2); if(jnz(0x1017_2138, 0xa)) goto l_0x1017_2138; /* jnz 0x10172138 */
            ii(0x1017_212e, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1017_2133, 5); jmp(0x1017_21a3, 0x6b); goto l_0x1017_21a3; /* jmp 0x101721a3 */
        l_0x1017_2138:
            ii(0x1017_2138, 3); mov(ah, memb[ds, eax + 0xd]);           /* mov ah, [eax+0xd] */
            ii(0x1017_213b, 2); xor(esi, esi);                          /* xor esi, esi */
            ii(0x1017_213d, 3); test(ah, 0x10);                         /* test ah, 0x10 */
            ii(0x1017_2140, 2); if(jz(0x1017_214b, 9)) goto l_0x1017_214b; /* jz 0x1017214b */
            ii(0x1017_2142, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1017_2144, 5); call(/* sys */ 0x1018_d5d9, 0x1_b490);  /* call 0x1018d5d9 */
            ii(0x1017_2149, 2); mov(esi, eax);                          /* mov esi, eax */
        l_0x1017_214b:
            ii(0x1017_214b, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1017_214d, 5); call(Definitions.sys_ftell, 0x5f5);     /* call 0x10172747 */
            ii(0x1017_2152, 3); cmp(eax, -1 /* 0xff */);                /* cmp eax, 0xffffffff */
            ii(0x1017_2155, 2); if(jz(0x1017_2165, 0xe)) goto l_0x1017_2165; /* jz 0x10172165 */
            ii(0x1017_2157, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_2159, 3); mov(ebp, memd[ds, ecx + 0x10]);         /* mov ebp, [ecx+0x10] */
            ii(0x1017_215c, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1017_215e, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1017_2160, 5); call(Definitions.sys_lseek, 0xb032);    /* call 0x1017d197 */
        l_0x1017_2165:
            ii(0x1017_2165, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1017_2167, 2); if(jz(0x1017_2173, 0xa)) goto l_0x1017_2173; /* jz 0x10172173 */
            ii(0x1017_2169, 3); mov(eax, memd[ds, ecx + 0x10]);         /* mov eax, [ecx+0x10] */
            ii(0x1017_216c, 5); call(/* sys */ 0x1018_d6b2, 0x1_b541);  /* call 0x1018d6b2 */
            ii(0x1017_2171, 2); or(esi, eax);                           /* or esi, eax */
        l_0x1017_2173:
            ii(0x1017_2173, 4); test(memb[ds, ecx + 0xc], 8);           /* test byte [ecx+0xc], 0x8 */
            ii(0x1017_2177, 2); if(jz(0x1017_2188, 0xf)) goto l_0x1017_2188; /* jz 0x10172188 */
            ii(0x1017_2179, 3); mov(eax, memd[ds, ecx + 8]);            /* mov eax, [ecx+0x8] */
            ii(0x1017_217c, 5); call(Definitions.sys_free, -0x70c0);    /* call 0x1016b0c1 */
            ii(0x1017_2181, 7); mov(memd[ds, ecx + 8], 0);              /* mov dword [ecx+0x8], 0x0 */
        l_0x1017_2188:
            ii(0x1017_2188, 4); test(memb[ds, ecx + 0xd], 8);           /* test byte [ecx+0xd], 0x8 */
            ii(0x1017_218c, 2); if(jz(0x1017_21a1, 0x13)) goto l_0x1017_21a1; /* jz 0x101721a1 */
            ii(0x1017_218e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_2190, 2); mov(eax, esp);                          /* mov eax, esp */
            ii(0x1017_2192, 3); mov(dl, memb[ds, ecx + 0x19]);          /* mov dl, [ecx+0x19] */
            ii(0x1017_2195, 5); call(/* sys */ 0x1017_20b7, -0xe3);     /* call 0x101720b7 */
            ii(0x1017_219a, 2); mov(eax, esp);                          /* mov eax, esp */
            ii(0x1017_219c, 5); call(/* sys */ 0x1018_d6e7, 0x1_b546);  /* call 0x1018d6e7 */
        l_0x1017_21a1:
            ii(0x1017_21a1, 2); mov(eax, esi);                          /* mov eax, esi */
        l_0x1017_21a3:
            ii(0x1017_21a3, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1017_21a6, 1); pop(ebp);                               /* pop ebp */
            ii(0x1017_21a7, 1); pop(edi);                               /* pop edi */
            ii(0x1017_21a8, 1); pop(esi);                               /* pop esi */
            ii(0x1017_21a9, 1); pop(ecx);                               /* pop ecx */
            ii(0x1017_21aa, 1); pop(ebx);                               /* pop ebx */
            ii(0x1017_21ab, 1); ret();                                  /* ret */
        }
    }
}
