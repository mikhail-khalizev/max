using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("fd71f4d1-78f5-4c4c-a7bc-b1b037e857c5")]
        public void Method_100f_6198()
        {
            ii(0x100f_6198, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x100f_619d, 5); calld(Definitions.sys_check_available_stack_size, 0x6_fbb0); /* call 0x10165d52 */
            ii(0x100f_61a2, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_61a3, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_61a4, 1); pushd(edx);                             /* push edx */
            ii(0x100f_61a5, 1); pushd(esi);                             /* push esi */
            ii(0x100f_61a6, 1); pushd(edi);                             /* push edi */
            ii(0x100f_61a7, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_61a8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_61aa, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100f_61b0, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100f_61b3, 5); mov(eax, 0x101c_39b4);                  /* mov eax, 0x101c39b4 */
            ii(0x100f_61b8, 5); calld(0x100e_aef0, -0xb2cd);            /* call 0x100eaef0 */
            ii(0x100f_61bd, 1); cwde();                                 /* cwde */
            ii(0x100f_61be, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_61c0, 2); if(jnzd(0x100f_61cb, 0x9)) goto l_0x100f_61cb; /* jnz 0x100f61cb */
            ii(0x100f_61c2, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x100f_61c6, 5); jmpd(0x100f_62cd, 0x102); goto l_0x100f_62cd; /* jmp 0x100f62cd */
        l_0x100f_61cb:
            ii(0x100f_61cb, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_61cf, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_61d1, 2); if(jld(0x100f_61de, 0xb)) goto l_0x100f_61de; /* jl 0x100f61de */
            ii(0x100f_61d3, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_61d7, 5); cmp(eax, 0x100);                        /* cmp eax, 0x100 */
            ii(0x100f_61dc, 2); if(jld(0x100f_61e7, 0x9)) goto l_0x100f_61e7; /* jl 0x100f61e7 */
        l_0x100f_61de:
            ii(0x100f_61de, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x100f_61e2, 5); jmpd(0x100f_62cd, 0xe6); goto l_0x100f_62cd; /* jmp 0x100f62cd */
        l_0x100f_61e7:
            ii(0x100f_61e7, 5); mov(eax, 0x101c_39b4);                  /* mov eax, 0x101c39b4 */
            ii(0x100f_61ec, 5); calld(0x100e_aef0, -0xb301);            /* call 0x100eaef0 */
            ii(0x100f_61f1, 1); cwde();                                 /* cwde */
            ii(0x100f_61f2, 3); cmp(eax, 0x1e);                         /* cmp eax, 0x1e */
            ii(0x100f_61f5, 2); if(jld(0x100f_620b, 0x14)) goto l_0x100f_620b; /* jl 0x100f620b */
            ii(0x100f_61f7, 5); mov(edx, StringDefinitions.Empty7);     /* mov edx, 0x101a25e1 */
            ii(0x100f_61fc, 5); mov(eax, 0x101c_39b4);                  /* mov eax, 0x101c39b4 */
            ii(0x100f_6201, 5); calld(0x1014_21cb, 0x4_bfc5);           /* call 0x101421cb */
            ii(0x100f_6206, 5); jmpd(0x100f_62c9, 0xbe); goto l_0x100f_62c9; /* jmp 0x100f62c9 */
        l_0x100f_620b:
            ii(0x100f_620b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_620e, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100f_6211, 2); jmpd(0x100f_6281, 0x6e); goto l_0x100f_6281; /* jmp 0x100f6281 */
        l_0x100f_6213:
            ii(0x100f_6213, 5); calld(0x1011_606c, 0x1_fe54);           /* call 0x1011606c */
            ii(0x100f_6218, 5); calld(0x100f_59ac, -0x871);             /* call 0x100f59ac */
            ii(0x100f_621d, 5); mov(edx, StringDefinitions.Empty8);     /* mov edx, 0x101a25e2 */
            ii(0x100f_6222, 5); mov(eax, 0x101c_39b4);                  /* mov eax, 0x101c39b4 */
            ii(0x100f_6227, 5); calld(0x1014_21cb, 0x4_bf9f);           /* call 0x101421cb */
            ii(0x100f_622c, 5); jmpd(0x100f_62a4, 0x73); goto l_0x100f_62a4; /* jmp 0x100f62a4 */
        l_0x100f_6231:
            ii(0x100f_6231, 5); mov(eax, 0x101c_39b4);                  /* mov eax, 0x101c39b4 */
            ii(0x100f_6236, 5); calld(0x100e_aef0, -0xb34b);            /* call 0x100eaef0 */
            ii(0x100f_623b, 3); sub(eax, 0x2);                          /* sub eax, 0x2 */
            ii(0x100f_623e, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100f_6241, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_6243, 3); lea(edx, ebp - 0x10);                   /* lea edx, [ebp-0x10] */
            ii(0x100f_6246, 5); mov(eax, 0x101c_39b4);                  /* mov eax, 0x101c39b4 */
            ii(0x100f_624b, 5); calld(0x1014_1ba3, 0x4_b953);           /* call 0x10141ba3 */
            ii(0x100f_6250, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_6252, 5); mov(eax, 0x101c_39b4);                  /* mov eax, 0x101c39b4 */
            ii(0x100f_6257, 5); calld(0x1014_2246, 0x4_bfea);           /* call 0x10142246 */
            ii(0x100f_625c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_625e, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100f_6261, 5); calld(Definitions.my_string_dtor, 0x4_b8c4); /* call 0x10141b2a */
            ii(0x100f_6266, 2); jmpd(0x100f_62a4, 0x3c); goto l_0x100f_62a4; /* jmp 0x100f62a4 */
        l_0x100f_6268:
            ii(0x100f_6268, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_626c, 5); calld(Definitions.sys_tolower, 0x7_c824); /* call 0x10172a95 */
            ii(0x100f_6271, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_6273, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100f_6275, 5); mov(eax, 0x101c_39b4);                  /* mov eax, 0x101c39b4 */
            ii(0x100f_627a, 5); calld(Definitions.my_string_append_char, 0x4_bb6b); /* call 0x10141dea */
            ii(0x100f_627f, 2); jmpd(0x100f_62a4, 0x23); goto l_0x100f_62a4; /* jmp 0x100f62a4 */
        l_0x100f_6281:
            ii(0x100f_6281, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100f_6284, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100f_6287, 5); cmp(memw_a32[ss, ebp - 0x14], 0x8);     /* cmp word [ebp-0x14], 0x8 */
            ii(0x100f_628c, 2); if(jbd(0x100f_62a2, 0x14)) goto l_0x100f_62a2; /* jb 0x100f62a2 */
            ii(0x100f_628e, 5); cmp(memw_a32[ss, ebp - 0x14], 0x8);     /* cmp word [ebp-0x14], 0x8 */
            ii(0x100f_6293, 2); if(jbed(0x100f_6231, -0x64)) goto l_0x100f_6231; /* jbe 0x100f6231 */
            ii(0x100f_6295, 5); cmp(memw_a32[ss, ebp - 0x14], 0xd);     /* cmp word [ebp-0x14], 0xd */
            ii(0x100f_629a, 6); if(jzd(0x100f_6213, -0x8d)) goto l_0x100f_6213; /* jz 0x100f6213 */
            ii(0x100f_62a0, 2); jmpd(0x100f_6268, -0x3a); goto l_0x100f_6268; /* jmp 0x100f6268 */
        l_0x100f_62a2:
            ii(0x100f_62a2, 2); jmpd(0x100f_6268, -0x3c); goto l_0x100f_6268; /* jmp 0x100f6268 */
        l_0x100f_62a4:
            ii(0x100f_62a4, 5); calld(0x100c_aa00, -0x2_b8a9);          /* call 0x100caa00 */
            ii(0x100f_62a9, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_62ae, 1); pushd(eax);                             /* push eax */
            ii(0x100f_62af, 5); calld(0x100c_aa20, -0x2_b894);          /* call 0x100caa20 */
            ii(0x100f_62b4, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100f_62b6, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_62b8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_62ba, 5); mov(eax, 0x101c_39b4);                  /* mov eax, 0x101c39b4 */
            ii(0x100f_62bf, 5); calld(Definitions.my_strobj_c_str_v2, -0x6_cafc); /* call 0x100897c8 */
            ii(0x100f_62c4, 5); calld(0x1011_5d23, 0x1_fa5a);           /* call 0x10115d23 */
        l_0x100f_62c9:
            ii(0x100f_62c9, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
        l_0x100f_62cd:
            ii(0x100f_62cd, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100f_62d0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_62d2, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_62d3, 1); popd(edi);                              /* pop edi */
            ii(0x100f_62d4, 1); popd(esi);                              /* pop esi */
            ii(0x100f_62d5, 1); popd(edx);                              /* pop edx */
            ii(0x100f_62d6, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_62d7, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_62d8, 1); retd(); return;                         /* ret */
        }
    }
}
