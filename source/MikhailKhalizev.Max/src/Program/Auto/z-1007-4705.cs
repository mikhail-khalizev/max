using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_4705-51713f1a")]
        public void Method_1007_4705()
        {
            ii(0x1007_4705, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1007_470a, 5); calld(Definitions.sys_check_available_stack_size, 0xf_1643); /* call 0x10165d52 */
            ii(0x1007_470f, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_4710, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_4711, 1); pushd(edx);                             /* push edx */
            ii(0x1007_4712, 1); pushd(esi);                             /* push esi */
            ii(0x1007_4713, 1); pushd(edi);                             /* push edi */
            ii(0x1007_4714, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_4715, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_4717, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1007_471d, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_4720, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_4723, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_4726, 2); jmpd(0x1007_475d, 0x35); goto l_0x1007_475d; /* jmp 0x1007475d */
        l_0x1007_4728:
            ii(0x1007_4728, 7); mov(memd_a32[ss, ebp - 0xc], 0x40);     /* mov dword [ebp-0xc], 0x40 */
            ii(0x1007_472f, 5); jmpd(0x1007_485f, 0x12b); goto l_0x1007_485f; /* jmp 0x1007485f */
        l_0x1007_4734:
            ii(0x1007_4734, 7); mov(memd_a32[ss, ebp - 0xc], 0x380);    /* mov dword [ebp-0xc], 0x380 */
            ii(0x1007_473b, 5); jmpd(0x1007_485f, 0x11f); goto l_0x1007_485f; /* jmp 0x1007485f */
        l_0x1007_4740:
            ii(0x1007_4740, 7); mov(memd_a32[ss, ebp - 0xc], 0x180);    /* mov dword [ebp-0xc], 0x180 */
            ii(0x1007_4747, 5); jmpd(0x1007_485f, 0x113); goto l_0x1007_485f; /* jmp 0x1007485f */
        l_0x1007_474c:
            ii(0x1007_474c, 7); mov(memd_a32[ss, ebp - 0xc], 0x3c0);    /* mov dword [ebp-0xc], 0x3c0 */
            ii(0x1007_4753, 5); jmpd(0x1007_485f, 0x107); goto l_0x1007_485f; /* jmp 0x1007485f */
        l_0x1007_4758:
            ii(0x1007_4758, 5); jmpd(0x1007_4858, 0xfb); goto l_0x1007_4858; /* jmp 0x10074858 */
        l_0x1007_475d:
            ii(0x1007_475d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_4760, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1007_4763, 5); cmp(memw_a32[ss, ebp - 0x10], 0x42);    /* cmp word [ebp-0x10], 0x42 */
            ii(0x1007_4768, 6); if(jbd(0x1007_47dd, 0x6f)) goto l_0x1007_47dd; /* jb 0x100747dd */
            ii(0x1007_476e, 5); cmp(memw_a32[ss, ebp - 0x10], 0x42);    /* cmp word [ebp-0x10], 0x42 */
            ii(0x1007_4773, 2); if(jbed(0x1007_4734, -0x41)) goto l_0x1007_4734; /* jbe 0x10074734 */
            ii(0x1007_4775, 5); cmp(memw_a32[ss, ebp - 0x10], 0x49);    /* cmp word [ebp-0x10], 0x49 */
            ii(0x1007_477a, 2); if(jbd(0x1007_47b7, 0x3b)) goto l_0x1007_47b7; /* jb 0x100747b7 */
            ii(0x1007_477c, 5); cmp(memw_a32[ss, ebp - 0x10], 0x49);    /* cmp word [ebp-0x10], 0x49 */
            ii(0x1007_4781, 2); if(jbed(0x1007_4734, -0x4f)) goto l_0x1007_4734; /* jbe 0x10074734 */
            ii(0x1007_4783, 5); cmp(memw_a32[ss, ebp - 0x10], 0x4d);    /* cmp word [ebp-0x10], 0x4d */
            ii(0x1007_4788, 2); if(jbd(0x1007_47aa, 0x20)) goto l_0x1007_47aa; /* jb 0x100747aa */
            ii(0x1007_478a, 5); cmp(memw_a32[ss, ebp - 0x10], 0x4d);    /* cmp word [ebp-0x10], 0x4d */
            ii(0x1007_478f, 2); if(jbed(0x1007_4734, -0x5d)) goto l_0x1007_4734; /* jbe 0x10074734 */
            ii(0x1007_4791, 5); cmp(memw_a32[ss, ebp - 0x10], 0x50);    /* cmp word [ebp-0x10], 0x50 */
            ii(0x1007_4796, 2); if(jbd(0x1007_47a8, 0x10)) goto l_0x1007_47a8; /* jb 0x100747a8 */
            ii(0x1007_4798, 5); cmp(memw_a32[ss, ebp - 0x10], 0x52);    /* cmp word [ebp-0x10], 0x52 */
            ii(0x1007_479d, 2); if(jbed(0x1007_4734, -0x6b)) goto l_0x1007_4734; /* jbe 0x10074734 */
            ii(0x1007_479f, 5); cmp(memw_a32[ss, ebp - 0x10], 0x53);    /* cmp word [ebp-0x10], 0x53 */
            ii(0x1007_47a4, 2); if(jzd(0x1007_474c, -0x5a)) goto l_0x1007_474c; /* jz 0x1007474c */
            ii(0x1007_47a6, 2); jmpd(0x1007_4758, -0x50); goto l_0x1007_4758; /* jmp 0x10074758 */
        l_0x1007_47a8:
            ii(0x1007_47a8, 2); jmpd(0x1007_4758, -0x52); goto l_0x1007_4758; /* jmp 0x10074758 */
        l_0x1007_47aa:
            ii(0x1007_47aa, 5); cmp(memw_a32[ss, ebp - 0x10], 0x4c);    /* cmp word [ebp-0x10], 0x4c */
            ii(0x1007_47af, 6); if(jzd(0x1007_4728, -0x8d)) goto l_0x1007_4728; /* jz 0x10074728 */
            ii(0x1007_47b5, 2); jmpd(0x1007_4758, -0x5f); goto l_0x1007_4758; /* jmp 0x10074758 */
        l_0x1007_47b7:
            ii(0x1007_47b7, 5); cmp(memw_a32[ss, ebp - 0x10], 0x44);    /* cmp word [ebp-0x10], 0x44 */
            ii(0x1007_47bc, 2); if(jbd(0x1007_47d8, 0x1a)) goto l_0x1007_47d8; /* jb 0x100747d8 */
            ii(0x1007_47be, 5); cmp(memw_a32[ss, ebp - 0x10], 0x44);    /* cmp word [ebp-0x10], 0x44 */
            ii(0x1007_47c3, 6); if(jbed(0x1007_4728, -0xa1)) goto l_0x1007_4728; /* jbe 0x10074728 */
            ii(0x1007_47c9, 5); cmp(memw_a32[ss, ebp - 0x10], 0x47);    /* cmp word [ebp-0x10], 0x47 */
            ii(0x1007_47ce, 6); if(jbed(0x1007_4734, -0xa0)) goto l_0x1007_4734; /* jbe 0x10074734 */
            ii(0x1007_47d4, 2); jmpd(0x1007_4758, -0x7e); goto l_0x1007_4758; /* jmp 0x10074758 */
        //  ii(0x1007_47d6, 2); jmpd(0x1007_4758, -0x80); goto l_0x1007_4758; /* jmp 0x10074758 */
        l_0x1007_47d8:
            ii(0x1007_47d8, 5); jmpd(0x1007_4734, -0xa9); goto l_0x1007_4734; /* jmp 0x10074734 */
        l_0x1007_47dd:
            ii(0x1007_47dd, 5); cmp(memw_a32[ss, ebp - 0x10], 0x29);    /* cmp word [ebp-0x10], 0x29 */
            ii(0x1007_47e2, 2); if(jbd(0x1007_4821, 0x3d)) goto l_0x1007_4821; /* jb 0x10074821 */
            ii(0x1007_47e4, 5); cmp(memw_a32[ss, ebp - 0x10], 0x2a);    /* cmp word [ebp-0x10], 0x2a */
            ii(0x1007_47e9, 6); if(jbed(0x1007_4740, -0xaf)) goto l_0x1007_4740; /* jbe 0x10074740 */
            ii(0x1007_47ef, 5); cmp(memw_a32[ss, ebp - 0x10], 0x33);    /* cmp word [ebp-0x10], 0x33 */
            ii(0x1007_47f4, 2); if(jbd(0x1007_4811, 0x1b)) goto l_0x1007_4811; /* jb 0x10074811 */
            ii(0x1007_47f6, 5); cmp(memw_a32[ss, ebp - 0x10], 0x36);    /* cmp word [ebp-0x10], 0x36 */
            ii(0x1007_47fb, 6); if(jbed(0x1007_4734, -0xcd)) goto l_0x1007_4734; /* jbe 0x10074734 */
            ii(0x1007_4801, 5); cmp(memw_a32[ss, ebp - 0x10], 0x37);    /* cmp word [ebp-0x10], 0x37 */
            ii(0x1007_4806, 6); if(jzd(0x1007_4728, -0xe4)) goto l_0x1007_4728; /* jz 0x10074728 */
            ii(0x1007_480c, 5); jmpd(0x1007_4758, -0xb9); goto l_0x1007_4758; /* jmp 0x10074758 */
        l_0x1007_4811:
            ii(0x1007_4811, 5); cmp(memw_a32[ss, ebp - 0x10], 0x32);    /* cmp word [ebp-0x10], 0x32 */
            ii(0x1007_4816, 6); if(jzd(0x1007_4734, -0xe8)) goto l_0x1007_4734; /* jz 0x10074734 */
            ii(0x1007_481c, 5); jmpd(0x1007_4758, -0xc9); goto l_0x1007_4758; /* jmp 0x10074758 */
        l_0x1007_4821:
            ii(0x1007_4821, 5); cmp(memw_a32[ss, ebp - 0x10], 0x23);    /* cmp word [ebp-0x10], 0x23 */
            ii(0x1007_4826, 2); if(jbd(0x1007_4848, 0x20)) goto l_0x1007_4848; /* jb 0x10074848 */
            ii(0x1007_4828, 5); cmp(memw_a32[ss, ebp - 0x10], 0x23);    /* cmp word [ebp-0x10], 0x23 */
            ii(0x1007_482d, 6); if(jbed(0x1007_4728, -0x10b)) goto l_0x1007_4728; /* jbe 0x10074728 */
            ii(0x1007_4833, 5); cmp(memw_a32[ss, ebp - 0x10], 0x25);    /* cmp word [ebp-0x10], 0x25 */
            ii(0x1007_4838, 6); if(jbed(0x1007_4734, -0x10a)) goto l_0x1007_4734; /* jbe 0x10074734 */
            ii(0x1007_483e, 5); jmpd(0x1007_4758, -0xeb); goto l_0x1007_4758; /* jmp 0x10074758 */
        //  ii(0x1007_4843, 5); jmpd(0x1007_4758, -0xf0); goto l_0x1007_4758; /* jmp 0x10074758 */
        l_0x1007_4848:
            ii(0x1007_4848, 5); cmp(memw_a32[ss, ebp - 0x10], 0x22);    /* cmp word [ebp-0x10], 0x22 */
            ii(0x1007_484d, 6); if(jzd(0x1007_4734, -0x11f)) goto l_0x1007_4734; /* jz 0x10074734 */
            ii(0x1007_4853, 5); jmpd(0x1007_4758, -0x100); goto l_0x1007_4758; /* jmp 0x10074758 */
        l_0x1007_4858:
            ii(0x1007_4858, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
        l_0x1007_485f:
            ii(0x1007_485f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_4862, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_4864, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_4865, 1); popd(edi);                              /* pop edi */
            ii(0x1007_4866, 1); popd(esi);                              /* pop esi */
            ii(0x1007_4867, 1); popd(edx);                              /* pop edx */
            ii(0x1007_4868, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_4869, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_486a, 1); retd();                                 /* ret */
        }
    }
}
