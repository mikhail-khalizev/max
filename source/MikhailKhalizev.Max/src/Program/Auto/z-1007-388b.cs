using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_388b-d69dc2ea")]
        public void Method_1007_388b()
        {
            ii(0x1007_388b, 5); push(0x2c);                             /* push 0x2c */
            ii(0x1007_3890, 5); call(Definitions.sys_check_available_stack_size, 0xf_24bd); /* call 0x10165d52 */
            ii(0x1007_3895, 1); push(esi);                              /* push esi */
            ii(0x1007_3896, 1); push(edi);                              /* push edi */
            ii(0x1007_3897, 1); push(ebp);                              /* push ebp */
            ii(0x1007_3898, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_389a, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1007_38a0, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1007_38a3, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1007_38a6, 3); mov(memd[ss, ebp - 0x8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1007_38a9, 3); mov(memd[ss, ebp - 0x10], ecx);         /* mov [ebp-0x10], ecx */
            ii(0x1007_38ac, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1007_38b0, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_38b2, 2); if(jl(0x1007_38c0, 0xc)) goto l_0x1007_38c0; /* jl 0x100738c0 */
            ii(0x1007_38b4, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_38b7, 7); cmp(ax, memw[ds, 0x101c_8172]);         /* cmp ax, [0x101c8172] */
            ii(0x1007_38be, 2); if(jl(0x1007_38c2, 0x2)) goto l_0x1007_38c2; /* jl 0x100738c2 */
        l_0x1007_38c0:
            ii(0x1007_38c0, 2); jmp(0x1007_38ca, 0x8); goto l_0x1007_38ca; /* jmp 0x100738ca */
        l_0x1007_38c2:
            ii(0x1007_38c2, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1007_38c6, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_38c8, 2); if(jge(0x1007_38cc, 0x2)) goto l_0x1007_38cc; /* jge 0x100738cc */
        l_0x1007_38ca:
            ii(0x1007_38ca, 2); jmp(0x1007_38d8, 0xc); goto l_0x1007_38d8; /* jmp 0x100738d8 */
        l_0x1007_38cc:
            ii(0x1007_38cc, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_38cf, 7); cmp(ax, memw[ds, 0x101c_8174]);         /* cmp ax, [0x101c8174] */
            ii(0x1007_38d6, 2); if(jl(0x1007_38e4, 0xc)) goto l_0x1007_38e4; /* jl 0x100738e4 */
        l_0x1007_38d8:
            ii(0x1007_38d8, 7); mov(memd[ss, ebp - 0x14], 0);           /* mov dword [ebp-0x14], 0x0 */
            ii(0x1007_38df, 5); jmp(0x1007_3a9d, 0x1b9); goto l_0x1007_3a9d; /* jmp 0x10073a9d */
        l_0x1007_38e4:
            ii(0x1007_38e4, 4); movsx(ebx, memw[ss, ebp - 0x4]);        /* movsx ebx, word [ebp-0x4] */
            ii(0x1007_38e8, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x1007_38ec, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1007_38f1, 5); call(0x1010_3541, 0x8_fc4b);            /* call 0x10103541 */
            ii(0x1007_38f6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_38f8, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_38fb, 5); call(0x1007_64b8, 0x2bb8);              /* call 0x100764b8 */
            ii(0x1007_3900, 7); mov(memd[ss, ebp - 0x1c], 0);           /* mov dword [ebp-0x1c], 0x0 */
            ii(0x1007_3907, 2); jmp(0x1007_3911, 0x8); goto l_0x1007_3911; /* jmp 0x10073911 */
        l_0x1007_3909:
            ii(0x1007_3909, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_390c, 5); call(0x1007_6bf8, 0x32e7);              /* call 0x10076bf8 */
        l_0x1007_3911:
            ii(0x1007_3911, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_3913, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_3916, 5); call(0x1013_ad71, 0xc_7456);            /* call 0x1013ad71 */
            ii(0x1007_391b, 2); test(al, al);                           /* test al, al */
            ii(0x1007_391d, 6); if(jz(0x1007_39b9, 0x96)) goto l_0x1007_39b9; /* jz 0x100739b9 */
            ii(0x1007_3923, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_3926, 5); call(0x1007_63a0, 0x2a75);              /* call 0x100763a0 */
            ii(0x1007_392b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_392d, 3); mov(dl, memb[ds, eax + 0x26]);          /* mov dl, [eax+0x26] */
            ii(0x1007_3930, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1007_3934, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_3936, 2); if(jnz(0x1007_3948, 0x10)) goto l_0x1007_3948; /* jnz 0x10073948 */
            ii(0x1007_3938, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_393b, 5); call(0x1007_63a0, 0x2a60);              /* call 0x100763a0 */
            ii(0x1007_3940, 3); mov(eax, memd[ds, eax + 0x12]);         /* mov eax, [eax+0x12] */
            ii(0x1007_3943, 3); test(memd[ss, ebp - 0x10], eax);        /* test [ebp-0x10], eax */
            ii(0x1007_3946, 2); if(jnz(0x1007_394a, 0x2)) goto l_0x1007_394a; /* jnz 0x1007394a */
        l_0x1007_3948:
            ii(0x1007_3948, 2); jmp(0x1007_3958, 0xe); goto l_0x1007_3958; /* jmp 0x10073958 */
        l_0x1007_394a:
            ii(0x1007_394a, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_394d, 5); call(0x1007_63a0, 0x2a4e);              /* call 0x100763a0 */
            ii(0x1007_3952, 4); cmp(memb[ds, eax + 0x3d], 0x10);        /* cmp byte [eax+0x3d], 0x10 */
            ii(0x1007_3956, 2); if(jnz(0x1007_395a, 0x2)) goto l_0x1007_395a; /* jnz 0x1007395a */
        l_0x1007_3958:
            ii(0x1007_3958, 2); jmp(0x1007_3973, 0x19); goto l_0x1007_3973; /* jmp 0x10073973 */
        l_0x1007_395a:
            ii(0x1007_395a, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_395d, 5); call(0x1007_63a0, 0x2a3e);              /* call 0x100763a0 */
            ii(0x1007_3962, 5); call(0x1007_6154, 0x27ed);              /* call 0x10076154 */
            ii(0x1007_3967, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1007_396c, 5); cmp(eax, 0xffff);                       /* cmp eax, 0xffff */
            ii(0x1007_3971, 2); if(jnz(0x1007_3975, 0x2)) goto l_0x1007_3975; /* jnz 0x10073975 */
        l_0x1007_3973:
            ii(0x1007_3973, 2); jmp(0x1007_3984, 0xf); goto l_0x1007_3984; /* jmp 0x10073984 */
        l_0x1007_3975:
            ii(0x1007_3975, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_3978, 5); call(0x1007_63a0, 0x2a23);              /* call 0x100763a0 */
            ii(0x1007_397d, 5); cmp(memw[ds, eax + 0x8], 0xf);          /* cmp word [eax+0x8], 0xf */
            ii(0x1007_3982, 2); if(jnz(0x1007_3986, 0x2)) goto l_0x1007_3986; /* jnz 0x10073986 */
        l_0x1007_3984:
            ii(0x1007_3984, 2); jmp(0x1007_3995, 0xf); goto l_0x1007_3995; /* jmp 0x10073995 */
        l_0x1007_3986:
            ii(0x1007_3986, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_3989, 5); call(0x1007_63a0, 0x2a12);              /* call 0x100763a0 */
            ii(0x1007_398e, 5); cmp(memw[ds, eax + 0x8], 0x10);         /* cmp word [eax+0x8], 0x10 */
            ii(0x1007_3993, 2); if(jnz(0x1007_3997, 0x2)) goto l_0x1007_3997; /* jnz 0x10073997 */
        l_0x1007_3995:
            ii(0x1007_3995, 2); jmp(0x1007_39a5, 0xe); goto l_0x1007_39a5; /* jmp 0x100739a5 */
        l_0x1007_3997:
            ii(0x1007_3997, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_399a, 5); call(0x1007_63a0, 0x2a01);              /* call 0x100763a0 */
            ii(0x1007_399f, 4); test(memb[ds, eax + 0x12], 0x1);        /* test byte [eax+0x12], 0x1 */
            ii(0x1007_39a3, 2); if(jz(0x1007_39a7, 0x2)) goto l_0x1007_39a7; /* jz 0x100739a7 */
        l_0x1007_39a5:
            ii(0x1007_39a5, 2); jmp(0x1007_39b4, 0xd); goto l_0x1007_39b4; /* jmp 0x100739b4 */
        l_0x1007_39a7:
            ii(0x1007_39a7, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_39aa, 5); call(0x1007_6408, 0x2a59);              /* call 0x10076408 */
            ii(0x1007_39af, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1007_39b2, 2); jmp(0x1007_39b9, 0x5); goto l_0x1007_39b9; /* jmp 0x100739b9 */
        l_0x1007_39b4:
            ii(0x1007_39b4, 5); jmp(0x1007_3909, -0xb0); goto l_0x1007_3909; /* jmp 0x10073909 */
        l_0x1007_39b9:
            ii(0x1007_39b9, 4); cmp(memd[ss, ebp - 0x1c], 0);           /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x1007_39bd, 6); if(jnz(0x1007_3a5c, 0x99)) goto l_0x1007_3a5c; /* jnz 0x10073a5c */
            ii(0x1007_39c3, 4); movsx(ebx, memw[ss, ebp - 0x4]);        /* movsx ebx, word [ebp-0x4] */
            ii(0x1007_39c7, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x1007_39cb, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1007_39d0, 5); call(0x1010_3541, 0x8_fb6c);            /* call 0x10103541 */
            ii(0x1007_39d5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_39d7, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_39da, 5); call(0x1007_643c, 0x2a5d);              /* call 0x1007643c */
            ii(0x1007_39df, 2); jmp(0x1007_39e9, 0x8); goto l_0x1007_39e9; /* jmp 0x100739e9 */
        l_0x1007_39e1:
            ii(0x1007_39e1, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_39e4, 5); call(0x1007_6bf8, 0x320f);              /* call 0x10076bf8 */
        l_0x1007_39e9:
            ii(0x1007_39e9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_39eb, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_39ee, 5); call(0x1013_ad71, 0xc_737e);            /* call 0x1013ad71 */
            ii(0x1007_39f3, 2); test(al, al);                           /* test al, al */
            ii(0x1007_39f5, 6); if(jz(0x1007_3a5c, 0x61)) goto l_0x1007_3a5c; /* jz 0x10073a5c */
            ii(0x1007_39fb, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_39fe, 5); call(0x1007_63a0, 0x299d);              /* call 0x100763a0 */
            ii(0x1007_3a03, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_3a05, 3); mov(dl, memb[ds, eax + 0x26]);          /* mov dl, [eax+0x26] */
            ii(0x1007_3a08, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1007_3a0c, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_3a0e, 2); if(jnz(0x1007_3a20, 0x10)) goto l_0x1007_3a20; /* jnz 0x10073a20 */
            ii(0x1007_3a10, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_3a13, 5); call(0x1007_63a0, 0x2988);              /* call 0x100763a0 */
            ii(0x1007_3a18, 3); mov(eax, memd[ds, eax + 0x12]);         /* mov eax, [eax+0x12] */
            ii(0x1007_3a1b, 3); test(memd[ss, ebp - 0x10], eax);        /* test [ebp-0x10], eax */
            ii(0x1007_3a1e, 2); if(jnz(0x1007_3a22, 0x2)) goto l_0x1007_3a22; /* jnz 0x10073a22 */
        l_0x1007_3a20:
            ii(0x1007_3a20, 2); jmp(0x1007_3a30, 0xe); goto l_0x1007_3a30; /* jmp 0x10073a30 */
        l_0x1007_3a22:
            ii(0x1007_3a22, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_3a25, 5); call(0x1007_63a0, 0x2976);              /* call 0x100763a0 */
            ii(0x1007_3a2a, 4); cmp(memb[ds, eax + 0x3d], 0x10);        /* cmp byte [eax+0x3d], 0x10 */
            ii(0x1007_3a2e, 2); if(jnz(0x1007_3a32, 0x2)) goto l_0x1007_3a32; /* jnz 0x10073a32 */
        l_0x1007_3a30:
            ii(0x1007_3a30, 2); jmp(0x1007_3a4b, 0x19); goto l_0x1007_3a4b; /* jmp 0x10073a4b */
        l_0x1007_3a32:
            ii(0x1007_3a32, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_3a35, 5); call(0x1007_63a0, 0x2966);              /* call 0x100763a0 */
            ii(0x1007_3a3a, 5); call(0x1007_6154, 0x2715);              /* call 0x10076154 */
            ii(0x1007_3a3f, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1007_3a44, 5); cmp(eax, 0xffff);                       /* cmp eax, 0xffff */
            ii(0x1007_3a49, 2); if(jnz(0x1007_3a4d, 0x2)) goto l_0x1007_3a4d; /* jnz 0x10073a4d */
        l_0x1007_3a4b:
            ii(0x1007_3a4b, 2); jmp(0x1007_3a5a, 0xd); goto l_0x1007_3a5a; /* jmp 0x10073a5a */
        l_0x1007_3a4d:
            ii(0x1007_3a4d, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_3a50, 5); call(0x1007_6408, 0x29b3);              /* call 0x10076408 */
            ii(0x1007_3a55, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1007_3a58, 2); jmp(0x1007_3a5c, 0x2); goto l_0x1007_3a5c; /* jmp 0x10073a5c */
        l_0x1007_3a5a:
            ii(0x1007_3a5a, 2); jmp(0x1007_39e1, -0x7b); goto l_0x1007_39e1; /* jmp 0x100739e1 */
        l_0x1007_3a5c:
            ii(0x1007_3a5c, 4); cmp(memd[ss, ebp - 0x1c], 0);           /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x1007_3a60, 2); if(jz(0x1007_3a81, 0x1f)) goto l_0x1007_3a81; /* jz 0x10073a81 */
            ii(0x1007_3a62, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1007_3a65, 5); cmp(memw[ds, eax + 0x8], 0xf);          /* cmp word [eax+0x8], 0xf */
            ii(0x1007_3a6a, 2); if(jz(0x1007_3a76, 0xa)) goto l_0x1007_3a76; /* jz 0x10073a76 */
            ii(0x1007_3a6c, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1007_3a6f, 5); cmp(memw[ds, eax + 0x8], 0x10);         /* cmp word [eax+0x8], 0x10 */
            ii(0x1007_3a74, 2); if(jnz(0x1007_3a81, 0xb)) goto l_0x1007_3a81; /* jnz 0x10073a81 */
        l_0x1007_3a76:
            ii(0x1007_3a76, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1007_3a79, 5); call(0x1007_611c, 0x269e);              /* call 0x1007611c */
            ii(0x1007_3a7e, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
        l_0x1007_3a81:
            ii(0x1007_3a81, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1007_3a84, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1007_3a87, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_3a89, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_3a8c, 5); call(0x1007_5f6c, 0x24db);              /* call 0x10075f6c */
            ii(0x1007_3a91, 2); jmp(0x1007_3a9d, 0xa); goto l_0x1007_3a9d; /* jmp 0x10073a9d */
        //  ii(0x1007_3a93, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1007_3a95, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
        //  ii(0x1007_3a98, 5); call(0x1007_5f6c, 0x24cf);              /* call 0x10075f6c */
        l_0x1007_3a9d:
            ii(0x1007_3a9d, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1007_3aa0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_3aa2, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_3aa3, 1); pop(edi);                               /* pop edi */
            ii(0x1007_3aa4, 1); pop(esi);                               /* pop esi */
            ii(0x1007_3aa5, 1); ret();                                  /* ret */
        }
    }
}
