using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_c051-310e3932")]
        public void Method_1008_c051()
        {
            ii(0x1008_c051, 5); push(0x24);                             /* push 0x24 */
            ii(0x1008_c056, 5); call(Definitions.sys_check_available_stack_size, 0xd_9cf7); /* call 0x10165d52 */
            ii(0x1008_c05b, 1); push(ebx);                              /* push ebx */
            ii(0x1008_c05c, 1); push(ecx);                              /* push ecx */
            ii(0x1008_c05d, 1); push(esi);                              /* push esi */
            ii(0x1008_c05e, 1); push(edi);                              /* push edi */
            ii(0x1008_c05f, 1); push(ebp);                              /* push ebp */
            ii(0x1008_c060, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_c062, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_c068, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_c06b, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1008_c06e, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1008_c071, 3); add(edx, 0x13);                         /* add edx, 0x13 */
            ii(0x1008_c074, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_c077, 5); call(0x1007_6d98, -0x1_52e4);           /* call 0x10076d98 */
            ii(0x1008_c07c, 2); test(al, al);                           /* test al, al */
            ii(0x1008_c07e, 6); if(jz(0x1008_c11a, 0x96)) goto l_0x1008_c11a; /* jz 0x1008c11a */
            ii(0x1008_c084, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1008_c087, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1008_c08a, 5); call(0x1008_b060, -0x102f);             /* call 0x1008b060 */
            ii(0x1008_c08f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_c092, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_c095, 5); call(0x1007_6574, -0x1_5b26);           /* call 0x10076574 */
            ii(0x1008_c09a, 4); mov(dx, memw[ds, eax + 0x52]);          /* mov dx, [eax+0x52] */
            ii(0x1008_c09e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_c0a1, 4); cmp(dx, memw[ds, eax + 0x1f]);          /* cmp dx, [eax+0x1f] */
            ii(0x1008_c0a5, 2); if(jl(0x1008_c0dd, 0x36)) goto l_0x1008_c0dd; /* jl 0x1008c0dd */
            ii(0x1008_c0a7, 5); call(0x1008_ac50, -0x145c);             /* call 0x1008ac50 */
            ii(0x1008_c0ac, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1008_c0ae, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1008_c0b0, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1008_c0b3, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_c0b6, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_c0b9, 5); call(0x1007_6574, -0x1_5b4a);           /* call 0x10076574 */
            ii(0x1008_c0be, 5); call(0x1015_2962, 0xc_689f);            /* call 0x10152962 */
            ii(0x1008_c0c3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_c0c5, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_c0c8, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1008_c0cb, 5); call(0x1008_afe4, -0x10ec);             /* call 0x1008afe4 */
            ii(0x1008_c0d0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_c0d2, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_c0d5, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_c0d8, 5); call(0x1007_6630, -0x1_5aad);           /* call 0x10076630 */
        l_0x1008_c0dd:
            ii(0x1008_c0dd, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_c0e0, 5); call(0x100a_71f8, 0x1_b113);            /* call 0x100a71f8 */
            ii(0x1008_c0e5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_c0e7, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_c0ea, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_c0ed, 5); call(0x1013_ad11, 0xa_ec1f);            /* call 0x1013ad11 */
            ii(0x1008_c0f2, 2); test(al, al);                           /* test al, al */
            ii(0x1008_c0f4, 2); if(jz(0x1008_c110, 0x1a)) goto l_0x1008_c110; /* jz 0x1008c110 */
            ii(0x1008_c0f6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_c0f8, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_c0fb, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1008_c0fe, 5); call(0x1008_afe4, -0x111f);             /* call 0x1008afe4 */
            ii(0x1008_c103, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1008_c106, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1008_c10b, 5); call(0x100a_5e27, 0x1_9d17);            /* call 0x100a5e27 */
        l_0x1008_c110:
            ii(0x1008_c110, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_c112, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1008_c115, 5); call(0x1008_8b7c, -0x359e);             /* call 0x10088b7c */
        l_0x1008_c11a:
            ii(0x1008_c11a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_c11c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_c11d, 1); pop(edi);                               /* pop edi */
            ii(0x1008_c11e, 1); pop(esi);                               /* pop esi */
            ii(0x1008_c11f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_c120, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_c121, 1); ret();                                  /* ret */
        }
    }
}
