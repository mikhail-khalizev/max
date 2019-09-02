using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_322d-47db118e")]
        public void Method_1013_322d()
        {
            ii(0x1013_322d, 5); push(0x3c);                             /* push 0x3c */
            ii(0x1013_3232, 5); call(Definitions.sys_check_available_stack_size, 0x3_2b1b); /* call 0x10165d52 */
            ii(0x1013_3237, 1); push(ecx);                              /* push ecx */
            ii(0x1013_3238, 1); push(esi);                              /* push esi */
            ii(0x1013_3239, 1); push(edi);                              /* push edi */
            ii(0x1013_323a, 1); push(ebp);                              /* push ebp */
            ii(0x1013_323b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_323d, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x1013_3243, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1013_3246, 3); mov(memb[ss, ebp - 4], dl);             /* mov [ebp-0x4], dl */
            ii(0x1013_3249, 3); mov(memd[ss, ebp - 8], ebx);            /* mov [ebp-0x8], ebx */
            ii(0x1013_324c, 4); movsx(eax, memw[ss, ebp - 12]);         /* movsx eax, word [ebp-0xc] */
            ii(0x1013_3250, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1013_3256, 5); mov(edx, 0x101c_a468);                  /* mov edx, 0x101ca468 */
            ii(0x1013_325b, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_325d, 4); movsx(eax, memb[ss, ebp - 4]);          /* movsx eax, byte [ebp-0x4] */
            ii(0x1013_3261, 3); imul(eax, eax, 0xc);                    /* imul eax, eax, 0xc */
            ii(0x1013_3264, 6); add(edx, 0x88);                         /* add edx, 0x88 */
            ii(0x1013_326a, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_326c, 3); mov(memd[ss, ebp - 16], edx);           /* mov [ebp-0x10], edx */
            ii(0x1013_326f, 3); mov(al, memb[ss, ebp - 4]);             /* mov al, [ebp-0x4] */
            ii(0x1013_3272, 2); add(al, 0x1e);                          /* add al, 0x1e */
            ii(0x1013_3274, 3); movsx(eax, al);                         /* movsx eax, al */
            ii(0x1013_3277, 5); call(0x1007_5fdc, -0xb_d2a0);           /* call 0x10075fdc */
            ii(0x1013_327c, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x1013_327f, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1013_3282, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1013_3284, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
            ii(0x1013_3287, 7); mov(memd[ss, ebp - 24], 0);             /* mov dword [ebp-0x18], 0x0 */
            ii(0x1013_328e, 3); fild(memq[ss, ebp - 28]);               /* fild qword [ebp-0x1c] */
            ii(0x1013_3291, 6); fdiv(memq[ds, 0x101a_8940]);            /* fdiv qword [0x101a8940] */
            ii(0x1013_3297, 2); fld1();                                 /* fld1 */
            ii(0x1013_3299, 2); faddp(ST(1), ST(0));                    /* faddp st1, st0 */
            ii(0x1013_329b, 3); fstp(memq[ss, ebp - 36]);               /* fstp qword [ebp-0x24] */
            ii(0x1013_329e, 3); fld(memq[ss, ebp - 36]);                /* fld qword [ebp-0x24] */
            ii(0x1013_32a1, 6); fadd(memq[ds, 0x101a_8948]);            /* fadd qword [0x101a8948] */
            ii(0x1013_32a7, 6); fld(memq[ds, 0x101a_8950]);             /* fld qword [0x101a8950] */
            ii(0x1013_32ad, 2); fxch(ST(0), ST(1));                     /* fxch st0, st1 */
            ii(0x1013_32af, 5); call(Definitions.sys_pow, 0x3_91ec);    /* call 0x1016c4a0 */
            ii(0x1013_32b4, 6); fmul(memq[ds, 0x101a_8958]);            /* fmul qword [0x101a8958] */
            ii(0x1013_32ba, 3); fild(memd[ss, ebp - 20]);               /* fild dword [ebp-0x14] */
            ii(0x1013_32bd, 2); fdivp(ST(1), ST(0));                    /* fdivp st1, st0 */
            ii(0x1013_32bf, 6); fld(memq[ds, 0x101a_8950]);             /* fld qword [0x101a8950] */
            ii(0x1013_32c5, 3); fld(memq[ss, ebp - 36]);                /* fld qword [ebp-0x24] */
            ii(0x1013_32c8, 5); call(Definitions.sys_pow, 0x3_91d3);    /* call 0x1016c4a0 */
            ii(0x1013_32cd, 6); fmul(memq[ds, 0x101a_8958]);            /* fmul qword [0x101a8958] */
            ii(0x1013_32d3, 3); fild(memd[ss, ebp - 20]);               /* fild dword [ebp-0x14] */
            ii(0x1013_32d6, 2); fdivp(ST(1), ST(0));                    /* fdivp st1, st0 */
            ii(0x1013_32d8, 2); fsubp(ST(1), ST(0));                    /* fsubp st1, st0 */
            ii(0x1013_32da, 5); call(Definitions.sys_round, 0x3_2d9f);  /* call 0x1016607e */
            ii(0x1013_32df, 3); fistp(memd[ss, ebp - 40]);              /* fistp dword [ebp-0x28] */
            ii(0x1013_32e2, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x1013_32e6, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1013_32e9, 3); add(memd[ds, eax + 8], edx);            /* add [eax+0x8], edx */
            ii(0x1013_32ec, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1013_32ef, 4); cmp(memd[ds, eax + 8], 0);              /* cmp dword [eax+0x8], 0x0 */
            ii(0x1013_32f3, 2); if(jz(0x1013_32fe, 9)) goto l_0x1013_32fe; /* jz 0x101332fe */
            ii(0x1013_32f5, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1013_32f8, 4); cmp(memd[ds, eax + 4], 0);              /* cmp dword [eax+0x4], 0x0 */
            ii(0x1013_32fc, 2); if(jz(0x1013_3300, 2)) goto l_0x1013_3300; /* jz 0x10133300 */
        l_0x1013_32fe:
            ii(0x1013_32fe, 2); jmp(0x1013_3309, 9); goto l_0x1013_3309; /* jmp 0x10133309 */
        l_0x1013_3300:
            ii(0x1013_3300, 3); mov(eax, memd[ss, ebp - 40]);           /* mov eax, [ebp-0x28] */
            ii(0x1013_3303, 3); mov(edx, memd[ss, ebp - 16]);           /* mov edx, [ebp-0x10] */
            ii(0x1013_3306, 3); mov(memd[ds, edx + 4], eax);            /* mov [edx+0x4], eax */
        l_0x1013_3309:
            ii(0x1013_3309, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1013_330c, 4); cmp(memd[ds, eax + 8], 0);              /* cmp dword [eax+0x8], 0x0 */
            ii(0x1013_3310, 2); if(jnz(0x1013_331d, 0xb)) goto l_0x1013_331d; /* jnz 0x1013331d */
            ii(0x1013_3312, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1013_3315, 3); mov(eax, memd[ds, eax + 4]);            /* mov eax, [eax+0x4] */
            ii(0x1013_3318, 3); cmp(eax, memd[ss, ebp - 40]);           /* cmp eax, [ebp-0x28] */
            ii(0x1013_331b, 2); if(jz(0x1013_331f, 2)) goto l_0x1013_331f; /* jz 0x1013331f */
        l_0x1013_331d:
            ii(0x1013_331d, 2); jmp(0x1013_3329, 0xa); goto l_0x1013_3329; /* jmp 0x10133329 */
        l_0x1013_331f:
            ii(0x1013_331f, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1013_3322, 7); mov(memd[ds, eax + 4], 0);              /* mov dword [eax+0x4], 0x0 */
        l_0x1013_3329:
            ii(0x1013_3329, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_332b, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_332c, 1); pop(edi);                               /* pop edi */
            ii(0x1013_332d, 1); pop(esi);                               /* pop esi */
            ii(0x1013_332e, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_332f, 1); ret();                                  /* ret */
        }
    }
}
