using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_9714-43b9e660")]
        public void /* sys */ Method_1016_9714()
        {
            ii(0x1016_9714, 1); push(ebx);                              /* push ebx */
            ii(0x1016_9715, 1); push(ecx);                              /* push ecx */
            ii(0x1016_9716, 1); push(edx);                              /* push edx */
            ii(0x1016_9717, 1); push(esi);                              /* push esi */
            ii(0x1016_9718, 1); push(edi);                              /* push edi */
            ii(0x1016_9719, 1); push(ebp);                              /* push ebp */
            ii(0x1016_971a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_971c, 4); test(memb[ds, eax + 6], 1);             /* test byte [eax+0x6], 0x1 */
            ii(0x1016_9720, 2); if(jnz(0x1016_9774, 0x52)) goto l_0x1016_9774; /* jnz 0x10169774 */
            ii(0x1016_9722, 3); mov(ebx, memd[ds, edx + 48]);           /* mov ebx, [edx+0x30] */
            ii(0x1016_9725, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1016_9727, 2); if(jz(0x1016_9730, 7)) goto l_0x1016_9730; /* jz 0x10169730 */
            ii(0x1016_9729, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1016_972b, 5); call(Definitions.sys_free_internal, 0x1_8d24); /* call 0x10182454 */
        l_0x1016_9730:
            ii(0x1016_9730, 3); mov(ecx, memd[ds, edx + 52]);           /* mov ecx, [edx+0x34] */
            ii(0x1016_9733, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1016_9735, 2); if(jz(0x1016_973e, 7)) goto l_0x1016_973e; /* jz 0x1016973e */
            ii(0x1016_9737, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1016_9739, 5); call(Definitions.sys_free_internal, 0x1_8d16); /* call 0x10182454 */
        l_0x1016_973e:
            ii(0x1016_973e, 3); mov(esi, memd[ds, edx + 56]);           /* mov esi, [edx+0x38] */
            ii(0x1016_9741, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1016_9743, 2); if(jz(0x1016_974c, 7)) goto l_0x1016_974c; /* jz 0x1016974c */
            ii(0x1016_9745, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_9747, 5); call(Definitions.sys_free_internal, 0x1_8d08); /* call 0x10182454 */
        l_0x1016_974c:
            ii(0x1016_974c, 3); mov(edi, memd[ds, edx + 60]);           /* mov edi, [edx+0x3c] */
            ii(0x1016_974f, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1016_9751, 2); if(jz(0x1016_975a, 7)) goto l_0x1016_975a; /* jz 0x1016975a */
            ii(0x1016_9753, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1016_9755, 5); call(Definitions.sys_free_internal, 0x1_8cfa); /* call 0x10182454 */
        l_0x1016_975a:
            ii(0x1016_975a, 3); mov(ebp, memd[ds, edx + 64]);           /* mov ebp, [edx+0x40] */
            ii(0x1016_975d, 2); test(ebp, ebp);                         /* test ebp, ebp */
            ii(0x1016_975f, 2); if(jz(0x1016_9768, 7)) goto l_0x1016_9768; /* jz 0x10169768 */
            ii(0x1016_9761, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1016_9763, 5); call(Definitions.sys_free_internal, 0x1_8cec); /* call 0x10182454 */
        l_0x1016_9768:
            ii(0x1016_9768, 3); mov(eax, memd[ds, edx + 68]);           /* mov eax, [edx+0x44] */
            ii(0x1016_976b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_976d, 2); if(jz(0x1016_9774, 5)) goto l_0x1016_9774; /* jz 0x10169774 */
            ii(0x1016_976f, 5); call(Definitions.sys_free_internal, 0x1_8ce0); /* call 0x10182454 */
        l_0x1016_9774:
            ii(0x1016_9774, 4); cmp(memd[ds, edx + 104], 0);            /* cmp dword [edx+0x68], 0x0 */
            ii(0x1016_9778, 2); if(jz(0x1016_97bf, 0x45)) goto l_0x1016_97bf; /* jz 0x101697bf */
            ii(0x1016_977a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_977c, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_977e, 2); jmp(0x1016_97b5, 0x35); goto l_0x1016_97b5; /* jmp 0x101697b5 */
        l_0x1016_9780:
            ii(0x1016_9780, 4); mov(edi, memd[ds, ecx + ebx + 16]);     /* mov edi, [ecx+ebx+0x10] */
            ii(0x1016_9784, 1); inc(eax);                               /* inc eax */
            ii(0x1016_9785, 2); cmp(edx, edi);                          /* cmp edx, edi */
            ii(0x1016_9787, 2); if(jnz(0x1016_97b2, 0x29)) goto l_0x1016_97b2; /* jnz 0x101697b2 */
            ii(0x1016_9789, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1016_978b, 7); lea(ecx, memd[ds, eax * 4]);            /* lea ecx, [eax*4] */
            ii(0x1016_9792, 2); jmp(0x1016_97a0, 0xc); goto l_0x1016_97a0; /* jmp 0x101697a0 */
        l_0x1016_9794:
            ii(0x1016_9794, 3); add(ecx, 4);                            /* add ecx, 0x4 */
            ii(0x1016_9797, 4); mov(esi, memd[ds, ecx + eax + 12]);     /* mov esi, [ecx+eax+0xc] */
            ii(0x1016_979b, 1); inc(ebx);                               /* inc ebx */
            ii(0x1016_979c, 4); mov(memd[ds, ecx + eax + 8], esi);      /* mov [ecx+eax+0x8], esi */
        l_0x1016_97a0:
            ii(0x1016_97a0, 3); mov(eax, memd[ds, edx + 104]);          /* mov eax, [edx+0x68] */
            ii(0x1016_97a3, 3); mov(ebp, memd[ds, eax + 12]);           /* mov ebp, [eax+0xc] */
            ii(0x1016_97a6, 2); cmp(ebx, ebp);                          /* cmp ebx, ebp */
            ii(0x1016_97a8, 2); if(jl(0x1016_9794, -0x16)) goto l_0x1016_9794; /* jl 0x10169794 */
            ii(0x1016_97aa, 3); lea(ebx, memd[ss, ebp - 1]);            /* lea ebx, [ebp-0x1] */
            ii(0x1016_97ad, 3); mov(memd[ds, eax + 12], ebx);           /* mov [eax+0xc], ebx */
            ii(0x1016_97b0, 2); jmp(0x1016_97bf, 0xd); goto l_0x1016_97bf; /* jmp 0x101697bf */
        l_0x1016_97b2:
            ii(0x1016_97b2, 3); add(ebx, 4);                            /* add ebx, 0x4 */
        l_0x1016_97b5:
            ii(0x1016_97b5, 3); mov(ecx, memd[ds, edx + 104]);          /* mov ecx, [edx+0x68] */
            ii(0x1016_97b8, 3); cmp(eax, memd[ds, ecx + 12]);           /* cmp eax, [ecx+0xc] */
            ii(0x1016_97bb, 2); if(jl(0x1016_9780, -0x3d)) goto l_0x1016_9780; /* jl 0x10169780 */
            ii(0x1016_97bd, 2); jmp(0x1016_97c6, 7); goto l_0x1016_97c6; /* jmp 0x101697c6 */
        l_0x1016_97bf:
            ii(0x1016_97bf, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_97c1, 5); call(Definitions.sys_free_internal, 0x1_8c8e); /* call 0x10182454 */
        l_0x1016_97c6:
            ii(0x1016_97c6, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_97c7, 1); pop(edi);                               /* pop edi */
            ii(0x1016_97c8, 1); pop(esi);                               /* pop esi */
            ii(0x1016_97c9, 1); pop(edx);                               /* pop edx */
            ii(0x1016_97ca, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_97cb, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_97cc, 1); ret();                                  /* ret */
        }
    }
}
