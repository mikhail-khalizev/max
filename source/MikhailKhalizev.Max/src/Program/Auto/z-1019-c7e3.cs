using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2e6c3197-351e-4301-b803-bdb694c50224")]
        public void Method_1019_c7e3()
        {
            ii(0x1019_c7e3, 1); pushd(ebp);                             /* push ebp */
            ii(0x1019_c7e4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_c7e6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_c7e7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_c7e8, 1); pushd(edx);                             /* push edx */
            ii(0x1019_c7e9, 1); pushd(esi);                             /* push esi */
            ii(0x1019_c7ea, 1); pushd(edi);                             /* push edi */
            ii(0x1019_c7eb, 3); sub(esp, 0x2c);                         /* sub esp, 0x2c */
            ii(0x1019_c7ee, 3); mov(ebx, memd_a32[ss, ebp + 0x10]);     /* mov ebx, [ebp+0x10] */
            ii(0x1019_c7f1, 3); mov(ecx, memd_a32[ss, ebp + 0x14]);     /* mov ecx, [ebp+0x14] */
            ii(0x1019_c7f4, 3); mov(esi, memd_a32[ss, ebp + 0x18]);     /* mov esi, [ebp+0x18] */
            ii(0x1019_c7f7, 3); mov(edx, memd_a32[ss, ebp + 0x20]);     /* mov edx, [ebp+0x20] */
            ii(0x1019_c7fa, 1); pushd(edx);                             /* push edx */
            ii(0x1019_c7fb, 3); mov(edi, memd_a32[ss, ebp + 0xc]);      /* mov edi, [ebp+0xc] */
            ii(0x1019_c7fe, 1); pushd(edi);                             /* push edi */
            ii(0x1019_c7ff, 3); mov(eax, memd_a32[ss, ebp + 0x8]);      /* mov eax, [ebp+0x8] */
            ii(0x1019_c802, 6); mov(memd_a32[ds, esi], 0);              /* mov dword [esi], 0x0 */
            ii(0x1019_c808, 1); pushd(eax);                             /* push eax */
            ii(0x1019_c809, 6); mov(memd_a32[ds, ecx], 0);              /* mov dword [ecx], 0x0 */
            ii(0x1019_c80f, 5); calld(0x1019_c548, -0x2cc);             /* call 0x1019c548 */
            ii(0x1019_c814, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1019_c816, 2); if(jzd(0x1019_c81f, 0x7)) goto l_0x1019_c81f; /* jz 0x1019c81f */
            ii(0x1019_c818, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1019_c81a, 5); jmpd(0x1019_c9b4, 0x195); goto l_0x1019_c9b4; /* jmp 0x1019c9b4 */
        l_0x1019_c81f:
            ii(0x1019_c81f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1019_c821, 2); xor(edi, edi);                          /* xor edi, edi */
            ii(0x1019_c823, 4); mov(memw_a32[ss, ebp - 0x2c], dx);      /* mov [ebp-0x2c], dx */
            ii(0x1019_c827, 4); mov(memw_a32[ss, ebp - 0x2a], di);      /* mov [ebp-0x2a], di */
            ii(0x1019_c82b, 4); mov(memw_a32[ss, ebp - 0x28], dx);      /* mov [ebp-0x28], dx */
            ii(0x1019_c82f, 4); mov(memw_a32[ss, ebp - 0x26], dx);      /* mov [ebp-0x26], dx */
            ii(0x1019_c833, 3); mov(edx, memd_a32[ss, ebp + 0xc]);      /* mov edx, [ebp+0xc] */
            ii(0x1019_c836, 3); mov(edi, memd_a32[ss, ebp + 0x8]);      /* mov edi, [ebp+0x8] */
            ii(0x1019_c839, 6); test(edx, 0x7fff_ffff);                 /* test edx, 0x7fffffff */
            ii(0x1019_c83f, 2); if(jnzd(0x1019_c849, 0x8)) goto l_0x1019_c849; /* jnz 0x1019c849 */
            ii(0x1019_c841, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1019_c843, 6); if(jzd(0x1019_c971, 0x128)) goto l_0x1019_c971; /* jz 0x1019c971 */
        l_0x1019_c849:
            ii(0x1019_c849, 2); fldz();                                 /* fldz */
            ii(0x1019_c84b, 3); fcomp(memq_a32[ss, ebp + 0x8]);         /* fcomp qword [ebp+0x8] */
            ii(0x1019_c84e, 2); fnstsw(ax);                             /* fnstsw ax */
            ii(0x1019_c850, 1); sahf();                                 /* sahf */
            ii(0x1019_c851, 2); if(jbed(0x1019_c861, 0xe)) goto l_0x1019_c861; /* jbe 0x1019c861 */
            ii(0x1019_c853, 3); fld(memq_a32[ss, ebp + 0x8]);           /* fld qword [ebp+0x8] */
            ii(0x1019_c856, 2); fchs();                                 /* fchs */
            ii(0x1019_c858, 6); mov(memd_a32[ds, esi], 0xffff_ffff);    /* mov dword [esi], 0xffffffff */
            ii(0x1019_c85e, 3); fstp(memq_a32[ss, ebp + 0x8]);          /* fstp qword [ebp+0x8] */
        l_0x1019_c861:
            ii(0x1019_c861, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_c862, 3); mov(eax, memd_a32[ss, ebp + 0xc]);      /* mov eax, [ebp+0xc] */
            ii(0x1019_c865, 1); pushd(eax);                             /* push eax */
            ii(0x1019_c866, 3); mov(edx, memd_a32[ss, ebp + 0x8]);      /* mov edx, [ebp+0x8] */
            ii(0x1019_c869, 1); pushd(edx);                             /* push edx */
            ii(0x1019_c86a, 5); calld(0x1019_cec2, 0x653);              /* call 0x1019cec2 */
            ii(0x1019_c86f, 2); mov(edx, memd_a32[ds, ecx]);            /* mov edx, [ecx] */
            ii(0x1019_c871, 2); fstp(ST(0));                            /* fstp st0 */
            ii(0x1019_c873, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1019_c875, 2); if(jged(0x1019_c879, 0x2)) goto l_0x1019_c879; /* jge 0x1019c879 */
            ii(0x1019_c877, 2); neg(edx);                               /* neg edx */
        l_0x1019_c879:
            ii(0x1019_c879, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1019_c87b, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1019_c87e, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1019_c880, 3); add(edx, 0x5);                          /* add edx, 0x5 */
            ii(0x1019_c883, 5); mov(edi, 0xa);                          /* mov edi, 0xa */
            ii(0x1019_c888, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1019_c88a, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1019_c88d, 2); idiv(edi);                              /* idiv edi */
            ii(0x1019_c88f, 2); mov(edi, memd_a32[ds, ecx]);            /* mov edi, [ecx] */
            ii(0x1019_c891, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1019_c893, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1019_c895, 2); if(jged(0x1019_c899, 0x2)) goto l_0x1019_c899; /* jge 0x1019c899 */
            ii(0x1019_c897, 2); neg(edx);                               /* neg edx */
        l_0x1019_c899:
            ii(0x1019_c899, 3); mov(eax, memd_a32[ss, ebp + 0x1c]);     /* mov eax, [ebp+0x1c] */
            ii(0x1019_c89c, 2); mov(memd_a32[ds, ecx], edx);            /* mov [ecx], edx */
            ii(0x1019_c89e, 3); cmp(eax, 0x46);                         /* cmp eax, 0x46 */
            ii(0x1019_c8a1, 2); if(jnzd(0x1019_c8a5, 0x2)) goto l_0x1019_c8a5; /* jnz 0x1019c8a5 */
            ii(0x1019_c8a3, 2); add(ebx, edx);                          /* add ebx, edx */
        l_0x1019_c8a5:
            ii(0x1019_c8a5, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1019_c8a7, 6); if(jld(0x1019_c93f, 0x92)) goto l_0x1019_c93f; /* jl 0x1019c93f */
            ii(0x1019_c8ad, 3); cmp(ebx, 0x10);                         /* cmp ebx, 0x10 */
            ii(0x1019_c8b0, 2); if(jled(0x1019_c8b7, 0x5)) goto l_0x1019_c8b7; /* jle 0x1019c8b7 */
            ii(0x1019_c8b2, 5); mov(ebx, 0x10);                         /* mov ebx, 0x10 */
        l_0x1019_c8b7:
            ii(0x1019_c8b7, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1019_c8b9, 3); mov(memb_a32[ss, ebp - 0x18], ah);      /* mov [ebp-0x18], ah */
            ii(0x1019_c8bc, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1019_c8bf, 1); pushd(eax);                             /* push eax */
            ii(0x1019_c8c0, 3); mov(edi, memd_a32[ss, ebp + 0xc]);      /* mov edi, [ebp+0xc] */
            ii(0x1019_c8c3, 1); pushd(edi);                             /* push edi */
            ii(0x1019_c8c4, 3); mov(eax, memd_a32[ss, ebp + 0x8]);      /* mov eax, [ebp+0x8] */
            ii(0x1019_c8c7, 1); pushd(eax);                             /* push eax */
            ii(0x1019_c8c8, 5); calld(0x1019_cce2, 0x415);              /* call 0x1019cce2 */
            ii(0x1019_c8cd, 2); fldz();                                 /* fldz */
            ii(0x1019_c8cf, 2); fcompp();                               /* fcompp */
            ii(0x1019_c8d1, 2); fnstsw(ax);                             /* fnstsw ax */
            ii(0x1019_c8d3, 1); sahf();                                 /* sahf */
            ii(0x1019_c8d4, 2); if(jnzd(0x1019_c8e1, 0xb)) goto l_0x1019_c8e1; /* jnz 0x1019c8e1 */
            ii(0x1019_c8d6, 2); cmp(ebx, edx);                          /* cmp ebx, edx */
            ii(0x1019_c8d8, 2); if(jled(0x1019_c8e1, 0x7)) goto l_0x1019_c8e1; /* jle 0x1019c8e1 */
            ii(0x1019_c8da, 2); mov(al, 0x1);                           /* mov al, 0x1 */
            ii(0x1019_c8dc, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1019_c8de, 3); mov(memb_a32[ss, ebp - 0x18], al);      /* mov [ebp-0x18], al */
        l_0x1019_c8e1:
            ii(0x1019_c8e1, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1019_c8e4, 1); pushd(eax);                             /* push eax */
            ii(0x1019_c8e5, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_c8e6, 3); mov(edi, memd_a32[ss, ebp + 0xc]);      /* mov edi, [ebp+0xc] */
            ii(0x1019_c8e9, 1); pushd(edi);                             /* push edi */
            ii(0x1019_c8ea, 3); mov(eax, memd_a32[ss, ebp + 0x8]);      /* mov eax, [ebp+0x8] */
            ii(0x1019_c8ed, 1); pushd(eax);                             /* push eax */
            ii(0x1019_c8ee, 2); mov(eax, memd_a32[ds, ecx]);            /* mov eax, [ecx] */
            ii(0x1019_c8f0, 5); calld(0x1019_c685, -0x270);             /* call 0x1019c685 */
            ii(0x1019_c8f5, 2); mov(edi, eax);                          /* mov edi, eax */
            ii(0x1019_c8f7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1019_c8f9, 2); if(jzd(0x1019_c93f, 0x44)) goto l_0x1019_c93f; /* jz 0x1019c93f */
            ii(0x1019_c8fb, 2); add(memd_a32[ds, ecx], eax);            /* add [ecx], eax */
            ii(0x1019_c8fd, 4); cmp(memd_a32[ss, ebp + 0x1c], 0x46);    /* cmp dword [ebp+0x1c], 0x46 */
            ii(0x1019_c901, 2); if(jzd(0x1019_c909, 0x6)) goto l_0x1019_c909; /* jz 0x1019c909 */
            ii(0x1019_c903, 4); cmp(memb_a32[ss, ebp - 0x18], 0);       /* cmp byte [ebp-0x18], 0x0 */
            ii(0x1019_c907, 2); if(jzd(0x1019_c90b, 0x2)) goto l_0x1019_c90b; /* jz 0x1019c90b */
        l_0x1019_c909:
            ii(0x1019_c909, 2); add(ebx, edi);                          /* add ebx, edi */
        l_0x1019_c90b:
            ii(0x1019_c90b, 3); cmp(ebx, 0x1);                          /* cmp ebx, 0x1 */
            ii(0x1019_c90e, 2); if(jged(0x1019_c917, 0x7)) goto l_0x1019_c917; /* jge 0x1019c917 */
            ii(0x1019_c910, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1019_c915, 2); jmpd(0x1019_c921, 0xa); goto l_0x1019_c921; /* jmp 0x1019c921 */
        l_0x1019_c917:
            ii(0x1019_c917, 3); cmp(ebx, 0x10);                         /* cmp ebx, 0x10 */
            ii(0x1019_c91a, 2); if(jled(0x1019_c921, 0x5)) goto l_0x1019_c921; /* jle 0x1019c921 */
            ii(0x1019_c91c, 5); mov(ebx, 0x10);                         /* mov ebx, 0x10 */
        l_0x1019_c921:
            ii(0x1019_c921, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1019_c924, 1); pushd(eax);                             /* push eax */
            ii(0x1019_c925, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_c926, 3); mov(edi, memd_a32[ss, ebp + 0xc]);      /* mov edi, [ebp+0xc] */
            ii(0x1019_c929, 1); pushd(edi);                             /* push edi */
            ii(0x1019_c92a, 3); mov(eax, memd_a32[ss, ebp + 0x8]);      /* mov eax, [ebp+0x8] */
            ii(0x1019_c92d, 1); pushd(eax);                             /* push eax */
            ii(0x1019_c92e, 2); mov(eax, memd_a32[ds, ecx]);            /* mov eax, [ecx] */
            ii(0x1019_c930, 5); calld(0x1019_c685, -0x2b0);             /* call 0x1019c685 */
            ii(0x1019_c935, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1019_c937, 2); if(jled(0x1019_c93f, 0x6)) goto l_0x1019_c93f; /* jle 0x1019c93f */
            ii(0x1019_c939, 2); mov(edi, memd_a32[ds, ecx]);            /* mov edi, [ecx] */
            ii(0x1019_c93b, 1); inc(edi);                               /* inc edi */
            ii(0x1019_c93c, 1); inc(ebx);                               /* inc ebx */
            ii(0x1019_c93d, 2); mov(memd_a32[ds, ecx], edi);            /* mov [ecx], edi */
        l_0x1019_c93f:
            ii(0x1019_c93f, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1019_c942, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1019_c945, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1019_c948, 3); mov(eax, memd_a32[ss, ebp - 0x2e]);     /* mov eax, [ebp-0x2e] */
            ii(0x1019_c94b, 3); mov(edi, memd_a32[ss, ebp - 0x1c]);     /* mov edi, [ebp-0x1c] */
            ii(0x1019_c94e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1019_c951, 2); or(eax, edi);                           /* or eax, edi */
            ii(0x1019_c953, 3); mov(edi, memd_a32[ss, ebp - 0x2a]);     /* mov edi, [ebp-0x2a] */
            ii(0x1019_c956, 3); sar(edi, 0x10);                         /* sar edi, 0x10 */
            ii(0x1019_c959, 2); or(eax, edi);                           /* or eax, edi */
            ii(0x1019_c95b, 3); mov(edi, memd_a32[ss, ebp - 0x28]);     /* mov edi, [ebp-0x28] */
            ii(0x1019_c95e, 3); sar(edi, 0x10);                         /* sar edi, 0x10 */
            ii(0x1019_c961, 2); or(eax, edi);                           /* or eax, edi */
            ii(0x1019_c963, 2); if(jnzd(0x1019_c971, 0xc)) goto l_0x1019_c971; /* jnz 0x1019c971 */
            ii(0x1019_c965, 2); mov(memd_a32[ds, esi], eax);            /* mov [esi], eax */
            ii(0x1019_c967, 2); mov(memd_a32[ds, ecx], eax);            /* mov [ecx], eax */
            ii(0x1019_c969, 4); cmp(memd_a32[ss, ebp + 0x1c], 0x46);    /* cmp dword [ebp+0x1c], 0x46 */
            ii(0x1019_c96d, 2); if(jnzd(0x1019_c971, 0x2)) goto l_0x1019_c971; /* jnz 0x1019c971 */
            ii(0x1019_c96f, 2); sub(ebx, edx);                          /* sub ebx, edx */
        l_0x1019_c971:
            ii(0x1019_c971, 3); cmp(ebx, 0x1);                          /* cmp ebx, 0x1 */
            ii(0x1019_c974, 2); if(jged(0x1019_c97d, 0x7)) goto l_0x1019_c97d; /* jge 0x1019c97d */
            ii(0x1019_c976, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1019_c97b, 2); jmpd(0x1019_c987, 0xa); goto l_0x1019_c987; /* jmp 0x1019c987 */
        l_0x1019_c97d:
            ii(0x1019_c97d, 3); cmp(ebx, 0x11);                         /* cmp ebx, 0x11 */
            ii(0x1019_c980, 2); if(jled(0x1019_c987, 0x5)) goto l_0x1019_c987; /* jle 0x1019c987 */
            ii(0x1019_c982, 5); mov(ebx, 0x11);                         /* mov ebx, 0x11 */
        l_0x1019_c987:
            ii(0x1019_c987, 3); lea(edx, ebp - 0x40);                   /* lea edx, [ebp-0x40] */
            ii(0x1019_c98a, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1019_c98d, 3); lea(esi, ebp - 0x40);                   /* lea esi, [ebp-0x40] */
            ii(0x1019_c990, 3); mov(edi, memd_a32[ss, ebp + 0x20]);     /* mov edi, [ebp+0x20] */
            ii(0x1019_c993, 5); calld(0x1019_cda1, 0x409);              /* call 0x1019cda1 */
            ii(0x1019_c998, 1); pushd(edi);                             /* push edi */
        l_0x1019_c999:
            ii(0x1019_c999, 2); mov(al, memb_a32[ds, esi]);             /* mov al, [esi] */
            ii(0x1019_c99b, 2); mov(memb_a32[ds, edi], al);             /* mov [edi], al */
            ii(0x1019_c99d, 2); cmp(al, 0);                             /* cmp al, 0x0 */
            ii(0x1019_c99f, 2); if(jzd(0x1019_c9b1, 0x10)) goto l_0x1019_c9b1; /* jz 0x1019c9b1 */
            ii(0x1019_c9a1, 3); mov(al, memb_a32[ds, esi + 0x1]);       /* mov al, [esi+0x1] */
            ii(0x1019_c9a4, 3); add(esi, 0x2);                          /* add esi, 0x2 */
            ii(0x1019_c9a7, 3); mov(memb_a32[ds, edi + 0x1], al);       /* mov [edi+0x1], al */
            ii(0x1019_c9aa, 3); add(edi, 0x2);                          /* add edi, 0x2 */
            ii(0x1019_c9ad, 2); cmp(al, 0);                             /* cmp al, 0x0 */
            ii(0x1019_c9af, 2); if(jnzd(0x1019_c999, -0x18)) goto l_0x1019_c999; /* jnz 0x1019c999 */
        l_0x1019_c9b1:
            ii(0x1019_c9b1, 1); popd(edi);                              /* pop edi */
            ii(0x1019_c9b2, 2); mov(eax, edi);                          /* mov eax, edi */
        l_0x1019_c9b4:
            ii(0x1019_c9b4, 3); lea(esp, ebp - 0x14);                   /* lea esp, [ebp-0x14] */
            ii(0x1019_c9b7, 1); popd(edi);                              /* pop edi */
            ii(0x1019_c9b8, 1); popd(esi);                              /* pop esi */
            ii(0x1019_c9b9, 1); popd(edx);                              /* pop edx */
            ii(0x1019_c9ba, 1); popd(ecx);                              /* pop ecx */
            ii(0x1019_c9bb, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_c9bc, 1); popd(ebp);                              /* pop ebp */
            ii(0x1019_c9bd, 3); retd(0x1c); return;                     /* ret 0x1c */
        }
    }
}
