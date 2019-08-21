using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_d901-3b0244ca")]
        public void Method_1008_d901()
        {
            ii(0x1008_d901, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x1008_d906, 5); calld(Definitions.sys_check_available_stack_size, 0xd_8447); /* call 0x10165d52 */
            ii(0x1008_d90b, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_d90c, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_d90d, 1); pushd(edx);                             /* push edx */
            ii(0x1008_d90e, 1); pushd(esi);                             /* push esi */
            ii(0x1008_d90f, 1); pushd(edi);                             /* push edi */
            ii(0x1008_d910, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_d911, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_d913, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1008_d919, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_d91c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_d91e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d921, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_d924, 5); calld(0x1013_ad11, 0xa_d3e8);           /* call 0x1013ad11 */
            ii(0x1008_d929, 2); test(al, al);                           /* test al, al */
            ii(0x1008_d92b, 2); if(jzd(0x1008_d960, 0x33)) goto l_0x1008_d960; /* jz 0x1008d960 */
            ii(0x1008_d92d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d930, 4); cmp(memb_a32[ds, eax + 0x25], 0x3);     /* cmp byte [eax+0x25], 0x3 */
            ii(0x1008_d934, 2); if(jzd(0x1008_d93f, 0x9)) goto l_0x1008_d93f; /* jz 0x1008d93f */
            ii(0x1008_d936, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d939, 4); cmp(memb_a32[ds, eax + 0x25], 0x9);     /* cmp byte [eax+0x25], 0x9 */
            ii(0x1008_d93d, 2); if(jld(0x1008_d941, 0x2)) goto l_0x1008_d941; /* jl 0x1008d941 */
        l_0x1008_d93f:
            ii(0x1008_d93f, 2); jmpd(0x1008_d951, 0x10); goto l_0x1008_d951; /* jmp 0x1008d951 */
        l_0x1008_d941:
            ii(0x1008_d941, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d944, 3); add(eax, 0x2b);                         /* add eax, 0x2b */
            ii(0x1008_d947, 5); calld(0x1007_6b90, -0x1_6dbc);          /* call 0x10076b90 */
            ii(0x1008_d94c, 1); cwde();                                 /* cwde */
            ii(0x1008_d94d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_d94f, 2); if(jzd(0x1008_d953, 0x2)) goto l_0x1008_d953; /* jz 0x1008d953 */
        l_0x1008_d951:
            ii(0x1008_d951, 2); jmpd(0x1008_d95b, 0x8); goto l_0x1008_d95b; /* jmp 0x1008d95b */
        l_0x1008_d953:
            ii(0x1008_d953, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d956, 5); calld(0x1008_d232, -0x729);             /* call 0x1008d232 */
        l_0x1008_d95b:
            ii(0x1008_d95b, 5); jmpd(0x1008_db55, 0x1f5); goto l_0x1008_db55; /* jmp 0x1008db55 */
        l_0x1008_d960:
            ii(0x1008_d960, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d963, 3); mov(al, memb_a32[ds, eax + 0x25]);      /* mov al, [eax+0x25] */
            ii(0x1008_d966, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
            ii(0x1008_d969, 5); jmpd(0x1008_db38, 0x1ca); goto l_0x1008_db38; /* jmp 0x1008db38 */
        l_0x1008_d96e:
            ii(0x1008_d96e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d971, 4); cmp(memb_a32[ds, eax + 0x6], 0);        /* cmp byte [eax+0x6], 0x0 */
            ii(0x1008_d975, 2); if(jzd(0x1008_d986, 0xf)) goto l_0x1008_d986; /* jz 0x1008d986 */
            ii(0x1008_d977, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d97a, 4); mov(memb_a32[ds, eax + 0x6], 0);        /* mov byte [eax+0x6], 0x0 */
            ii(0x1008_d97e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d981, 5); calld(0x1008_f76b, 0x1de5);             /* call 0x1008f76b */
        l_0x1008_d986:
            ii(0x1008_d986, 5); jmpd(0x1008_db55, 0x1ca); goto l_0x1008_db55; /* jmp 0x1008db55 */
        l_0x1008_d98b:
            ii(0x1008_d98b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d98e, 5); calld(0x1008_f76b, 0x1dd8);             /* call 0x1008f76b */
            ii(0x1008_d993, 5); jmpd(0x1008_db55, 0x1bd); goto l_0x1008_db55; /* jmp 0x1008db55 */
        l_0x1008_d998:
            ii(0x1008_d998, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d99b, 5); calld(0x1008_d6ba, -0x2e6);             /* call 0x1008d6ba */
            ii(0x1008_d9a0, 2); test(al, al);                           /* test al, al */
            ii(0x1008_d9a2, 6); if(jnzd(0x1008_db55, 0x1ad)) goto l_0x1008_db55; /* jnz 0x1008db55 */
            ii(0x1008_d9a8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d9ab, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_d9ae, 5); calld(0x1007_6574, -0x1_743f);          /* call 0x10076574 */
            ii(0x1008_d9b3, 4); cmp(memb_a32[ds, eax + 0x3d], 0);       /* cmp byte [eax+0x3d], 0x0 */
            ii(0x1008_d9b7, 2); if(jnzd(0x1008_d9ce, 0x15)) goto l_0x1008_d9ce; /* jnz 0x1008d9ce */
            ii(0x1008_d9b9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d9bc, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_d9bf, 5); calld(0x1007_6574, -0x1_7450);          /* call 0x10076574 */
            ii(0x1008_d9c4, 5); calld(0x1015_26ac, 0xc_4ce3);           /* call 0x101526ac */
            ii(0x1008_d9c9, 3); cmp(eax, memd_a32[ss, ebp - 0x4]);      /* cmp eax, [ebp-0x4] */
            ii(0x1008_d9cc, 2); if(jzd(0x1008_d9d0, 0x2)) goto l_0x1008_d9d0; /* jz 0x1008d9d0 */
        l_0x1008_d9ce:
            ii(0x1008_d9ce, 2); jmpd(0x1008_d9ef, 0x1f); goto l_0x1008_d9ef; /* jmp 0x1008d9ef */
        l_0x1008_d9d0:
            ii(0x1008_d9d0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d9d3, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_d9d6, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_d9d9, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x1008_d9dc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d9df, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_d9e2, 5); calld(0x1007_65d0, -0x1_7417);          /* call 0x100765d0 */
            ii(0x1008_d9e7, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_d9e9, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_d9ec, 3); calld_abs(memd_a32[ds, ebx + 0x44]);    /* call dword [ebx+0x44] */
        l_0x1008_d9ef:
            ii(0x1008_d9ef, 5); jmpd(0x1008_db55, 0x161); goto l_0x1008_db55; /* jmp 0x1008db55 */
        l_0x1008_d9f4:
            ii(0x1008_d9f4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d9f7, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_d9fa, 5); calld(0x1007_6574, -0x1_748b);          /* call 0x10076574 */
            ii(0x1008_d9ff, 5); calld(0x1015_26ac, 0xc_4ca8);           /* call 0x101526ac */
            ii(0x1008_da04, 3); cmp(eax, memd_a32[ss, ebp - 0x4]);      /* cmp eax, [ebp-0x4] */
            ii(0x1008_da07, 6); if(jnzd(0x1008_dac2, 0xb5)) goto l_0x1008_dac2; /* jnz 0x1008dac2 */
            ii(0x1008_da0d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_da10, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_da13, 5); calld(0x1007_6574, -0x1_74a4);          /* call 0x10076574 */
            ii(0x1008_da18, 4); cmp(memb_a32[ds, eax + 0x3d], 0);       /* cmp byte [eax+0x3d], 0x0 */
            ii(0x1008_da1c, 2); if(jnzd(0x1008_da37, 0x19)) goto l_0x1008_da37; /* jnz 0x1008da37 */
            ii(0x1008_da1e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_da21, 4); mov(memb_a32[ds, eax + 0x25], 0x7);     /* mov byte [eax+0x25], 0x7 */
            ii(0x1008_da25, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1008_da2a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_da2d, 5); calld(0x100a_28ff, 0x1_4ecd);           /* call 0x100a28ff */
            ii(0x1008_da32, 5); jmpd(0x1008_dac2, 0x8b); goto l_0x1008_dac2; /* jmp 0x1008dac2 */
        l_0x1008_da37:
            ii(0x1008_da37, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_da3a, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_da3d, 5); calld(0x1007_6574, -0x1_74ce);          /* call 0x10076574 */
            ii(0x1008_da42, 4); cmp(memb_a32[ds, eax + 0x3e], 0x1f);    /* cmp byte [eax+0x3e], 0x1f */
            ii(0x1008_da46, 2); if(jnzd(0x1008_da5d, 0x15)) goto l_0x1008_da5d; /* jnz 0x1008da5d */
            ii(0x1008_da48, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_da4b, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_da4e, 5); calld(0x1007_6574, -0x1_74df);          /* call 0x10076574 */
            ii(0x1008_da53, 5); calld(0x1015_26ac, 0xc_4c54);           /* call 0x101526ac */
            ii(0x1008_da58, 3); cmp(eax, memd_a32[ss, ebp - 0x4]);      /* cmp eax, [ebp-0x4] */
            ii(0x1008_da5b, 2); if(jzd(0x1008_da5f, 0x2)) goto l_0x1008_da5f; /* jz 0x1008da5f */
        l_0x1008_da5d:
            ii(0x1008_da5d, 2); jmpd(0x1008_da69, 0xa); goto l_0x1008_da69; /* jmp 0x1008da69 */
        l_0x1008_da5f:
            ii(0x1008_da5f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_da62, 5); calld(0x1008_d461, -0x606);             /* call 0x1008d461 */
            ii(0x1008_da67, 2); jmpd(0x1008_dac2, 0x59); goto l_0x1008_dac2; /* jmp 0x1008dac2 */
        l_0x1008_da69:
            ii(0x1008_da69, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_da6c, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_da6f, 5); calld(0x1007_6574, -0x1_7500);          /* call 0x10076574 */
            ii(0x1008_da74, 4); cmp(memb_a32[ds, eax + 0x3d], 0x4);     /* cmp byte [eax+0x3d], 0x4 */
            ii(0x1008_da78, 2); if(jnzd(0x1008_da8b, 0x11)) goto l_0x1008_da8b; /* jnz 0x1008da8b */
            ii(0x1008_da7a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_da7d, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_da80, 5); calld(0x1007_6574, -0x1_7511);          /* call 0x10076574 */
            ii(0x1008_da85, 4); cmp(memb_a32[ds, eax + 0x3e], 0xb);     /* cmp byte [eax+0x3e], 0xb */
            ii(0x1008_da89, 2); if(jzd(0x1008_da8d, 0x2)) goto l_0x1008_da8d; /* jz 0x1008da8d */
        l_0x1008_da8b:
            ii(0x1008_da8b, 2); jmpd(0x1008_dab8, 0x2b); goto l_0x1008_dab8; /* jmp 0x1008dab8 */
        l_0x1008_da8d:
            ii(0x1008_da8d, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1008_da8f, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x1008_da94, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_da97, 3); add(edx, 0x21);                         /* add edx, 0x21 */
            ii(0x1008_da9a, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1008_da9d, 5); calld(0x1007_5e64, -0x1_7c3e);          /* call 0x10075e64 */
            ii(0x1008_daa2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_daa4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_daa7, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_daaa, 5); calld(0x1008_abbc, -0x2ef3);            /* call 0x1008abbc */
            ii(0x1008_daaf, 5); calld(0x100a_90f9, 0x1_b645);           /* call 0x100a90f9 */
            ii(0x1008_dab4, 2); test(al, al);                           /* test al, al */
            ii(0x1008_dab6, 2); if(jnzd(0x1008_daba, 0x2)) goto l_0x1008_daba; /* jnz 0x1008daba */
        l_0x1008_dab8:
            ii(0x1008_dab8, 2); jmpd(0x1008_dac2, 0x8); goto l_0x1008_dac2; /* jmp 0x1008dac2 */
        l_0x1008_daba:
            ii(0x1008_daba, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_dabd, 5); calld(0x1008_d5fb, -0x4c7);             /* call 0x1008d5fb */
        l_0x1008_dac2:
            ii(0x1008_dac2, 5); jmpd(0x1008_db55, 0x8e); goto l_0x1008_db55; /* jmp 0x1008db55 */
        l_0x1008_dac7:
            ii(0x1008_dac7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_daca, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_dacd, 5); calld(0x1007_6574, -0x1_755e);          /* call 0x10076574 */
            ii(0x1008_dad2, 4); cmp(memb_a32[ds, eax + 0x3d], 0);       /* cmp byte [eax+0x3d], 0x0 */
            ii(0x1008_dad6, 2); if(jnzd(0x1008_daed, 0x15)) goto l_0x1008_daed; /* jnz 0x1008daed */
            ii(0x1008_dad8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_dadb, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_dade, 5); calld(0x1007_6574, -0x1_756f);          /* call 0x10076574 */
            ii(0x1008_dae3, 5); calld(0x1015_26ac, 0xc_4bc4);           /* call 0x101526ac */
            ii(0x1008_dae8, 3); cmp(eax, memd_a32[ss, ebp - 0x4]);      /* cmp eax, [ebp-0x4] */
            ii(0x1008_daeb, 2); if(jzd(0x1008_daef, 0x2)) goto l_0x1008_daef; /* jz 0x1008daef */
        l_0x1008_daed:
            ii(0x1008_daed, 2); jmpd(0x1008_daf7, 0x8); goto l_0x1008_daf7; /* jmp 0x1008daf7 */
        l_0x1008_daef:
            ii(0x1008_daef, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_daf2, 5); calld(0x1008_e07b, 0x584);              /* call 0x1008e07b */
        l_0x1008_daf7:
            ii(0x1008_daf7, 2); jmpd(0x1008_db55, 0x5c); goto l_0x1008_db55; /* jmp 0x1008db55 */
        l_0x1008_daf9:
            ii(0x1008_daf9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_dafc, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1008_daff, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1008_db02, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x1008_db05, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_db08, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_db0b, 5); calld(0x1007_65d0, -0x1_7540);          /* call 0x100765d0 */
            ii(0x1008_db10, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_db12, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1008_db15, 3); calld_abs(memd_a32[ds, ebx + 0x44]);    /* call dword [ebx+0x44] */
            ii(0x1008_db18, 2); jmpd(0x1008_db55, 0x3b); goto l_0x1008_db55; /* jmp 0x1008db55 */
        //  ii(0x1008_db1a, 2); mov(eax, eax);                          /* mov eax, eax */
        //  ii(0x1008_db1c, 28); /* Служебная область с абсолютными адресами переходов. (0x1008_d98b, 0x1008_d96e, 0x1008_d998, 0x1008_daf9, 0x1008_d9f4, 0x1008_daf9, 0x1008_dac7). */
        l_0x1008_db38:
            ii(0x1008_db38, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1008_db3b, 2); sub(al, 0x5);                           /* sub al, 0x5 */
            ii(0x1008_db3d, 3); mov(memb_a32[ss, ebp - 0x18], al);      /* mov [ebp-0x18], al */
            ii(0x1008_db40, 4); cmp(memb_a32[ss, ebp - 0x18], 0x6);     /* cmp byte [ebp-0x18], 0x6 */
            ii(0x1008_db44, 2); if(jad(0x1008_daf9, -0x4d)) goto l_0x1008_daf9; /* ja 0x1008daf9 */
            ii(0x1008_db46, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1008_db48, 3); mov(al, memb_a32[ss, ebp - 0x18]);      /* mov al, [ebp-0x18] */
            ii(0x1008_db4b, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1008_db4e, 7); 
            switch (jmpd_abs_switch(memd_a32[cs, eax + 0x1008_db1c]))
            {
                case 0x1008_d96e:
                    goto l_0x1008_d96e;
                case 0x1008_d98b:
                    goto l_0x1008_d98b;
                case 0x1008_d998:
                    goto l_0x1008_d998;
                case 0x1008_d9f4:
                    goto l_0x1008_d9f4;
                case 0x1008_dac7:
                    goto l_0x1008_dac7;
                case 0x1008_daf9:
                    goto l_0x1008_daf9;
                default:
                    throw new NotImplementedException();
            } /* jmp dword [cs:eax+0x1008db1c] */
        l_0x1008_db55:
            ii(0x1008_db55, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_db57, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_db58, 1); popd(edi);                              /* pop edi */
            ii(0x1008_db59, 1); popd(esi);                              /* pop esi */
            ii(0x1008_db5a, 1); popd(edx);                              /* pop edx */
            ii(0x1008_db5b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_db5c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_db5d, 1); retd(); return;                         /* ret */
        }
    }
}
