using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_685e-e08c3adb")]
        public void Method_1008_685e()
        {
            ii(0x1008_685e, 5); pushd(0x38);                            /* push 0x38 */
            ii(0x1008_6863, 5); calld(Definitions.sys_check_available_stack_size, 0xd_f4ea); /* call 0x10165d52 */
            ii(0x1008_6868, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_6869, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_686a, 1); pushd(esi);                             /* push esi */
            ii(0x1008_686b, 1); pushd(edi);                             /* push edi */
            ii(0x1008_686c, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_686d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_686f, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1008_6875, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_6878, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_687b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_687e, 5); calld(0x1008_a370, 0x3aed);             /* call 0x1008a370 */
            ii(0x1008_6883, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1008_6886, 4); cmp(memd_a32[ss, ebp - 0x18], 0);       /* cmp dword [ebp-0x18], 0x0 */
            ii(0x1008_688a, 2); if(jzd(0x1008_689b, 0xf)) goto l_0x1008_689b; /* jz 0x1008689b */
            ii(0x1008_688c, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1008_688f, 3); mov(al, memb_a32[ds, eax + 0x54]);      /* mov al, [eax+0x54] */
            ii(0x1008_6892, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1008_6897, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_6899, 2); if(jnzd(0x1008_68a4, 0x9)) goto l_0x1008_68a4; /* jnz 0x100868a4 */
        l_0x1008_689b:
            ii(0x1008_689b, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1008_689f, 5); jmpd(0x1008_6945, 0xa1); goto l_0x1008_6945; /* jmp 0x10086945 */
        l_0x1008_68a4:
            ii(0x1008_68a4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_68a7, 3); add(eax, 0x16);                         /* add eax, 0x16 */
            ii(0x1008_68aa, 5); calld(0x1008_9d08, 0x3459);             /* call 0x10089d08 */
            ii(0x1008_68af, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_68b1, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1008_68b4, 5); calld(0x1008_9be4, 0x332b);             /* call 0x10089be4 */
            ii(0x1008_68b9, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1008_68bc, 5); calld(0x1015_2aa9, 0xc_c1e8);           /* call 0x10152aa9 */
            ii(0x1008_68c1, 3); sub(eax, 0x3);                          /* sub eax, 0x3 */
            ii(0x1008_68c4, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1008_68c7, 3); lea(edx, ebp - 0x1c);                   /* lea edx, [ebp-0x1c] */
            ii(0x1008_68ca, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_68cd, 5); calld(0x100b_8e63, 0x3_2591);           /* call 0x100b8e63 */
            ii(0x1008_68d2, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_68d5, 4); imul(eax, memd_a32[ss, ebp - 0x10]);    /* imul eax, [ebp-0x10] */
            ii(0x1008_68d9, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1008_68dc, 2); jmpd(0x1008_68e6, 0x8); goto l_0x1008_68e6; /* jmp 0x100868e6 */
        l_0x1008_68de:
            ii(0x1008_68de, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1008_68e1, 5); calld(0x1007_6bf8, -0xfcee);            /* call 0x10076bf8 */
        l_0x1008_68e6:
            ii(0x1008_68e6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_68e8, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1008_68eb, 5); calld(0x1013_ad71, 0xb_4481);           /* call 0x1013ad71 */
            ii(0x1008_68f0, 2); test(al, al);                           /* test al, al */
            ii(0x1008_68f2, 2); if(jzd(0x1008_692b, 0x37)) goto l_0x1008_692b; /* jz 0x1008692b */
            ii(0x1008_68f4, 3); lea(edx, ebp - 0x1c);                   /* lea edx, [ebp-0x1c] */
            ii(0x1008_68f7, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1008_68fa, 5); calld(0x1007_5e64, -0x1_0a9b);          /* call 0x10075e64 */
            ii(0x1008_68ff, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_6901, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1008_6904, 5); calld(0x1008_9acc, 0x31c3);             /* call 0x10089acc */
            ii(0x1008_6909, 5); calld(0x1008_9f70, 0x3662);             /* call 0x10089f70 */
            ii(0x1008_690e, 5); calld(0x1007_0ca1, -0x1_5c72);          /* call 0x10070ca1 */
            ii(0x1008_6913, 4); cmp(ax, memw_a32[ss, ebp - 0x10]);      /* cmp ax, [ebp-0x10] */
            ii(0x1008_6917, 2); if(jgd(0x1008_6929, 0x10)) goto l_0x1008_6929; /* jg 0x10086929 */
            ii(0x1008_6919, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1008_691d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_691f, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1008_6922, 5); calld(0x1008_9044, 0x271d);             /* call 0x10089044 */
            ii(0x1008_6927, 2); jmpd(0x1008_6945, 0x1c); goto l_0x1008_6945; /* jmp 0x10086945 */
        l_0x1008_6929:
            ii(0x1008_6929, 2); jmpd(0x1008_68de, -0x4d); goto l_0x1008_68de; /* jmp 0x100868de */
        l_0x1008_692b:
            ii(0x1008_692b, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1008_692f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_6931, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1008_6934, 5); calld(0x1008_9044, 0x270b);             /* call 0x10089044 */
            ii(0x1008_6939, 2); jmpd(0x1008_6945, 0xa); goto l_0x1008_6945; /* jmp 0x10086945 */
        //  ii(0x1008_693b, 10); Недостижимый код.
        l_0x1008_6945:
            ii(0x1008_6945, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1008_6948, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_694a, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_694b, 1); popd(edi);                              /* pop edi */
            ii(0x1008_694c, 1); popd(esi);                              /* pop esi */
            ii(0x1008_694d, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_694e, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_694f, 1); retd(); return;                         /* ret */
        }
    }
}
