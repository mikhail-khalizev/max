using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f8afa57b-768a-4429-b26b-d0c24b19d3ff")]
        public void Method_1007_1f2e()
        {
            ii(0x1007_1f2e, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1007_1f33, 5); calld(Definitions.sys_check_available_stack_size, 0xf3e1a); /* call 0x10165d52 */
            ii(0x1007_1f38, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_1f39, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_1f3a, 1); pushd(edx);                             /* push edx */
            ii(0x1007_1f3b, 1); pushd(esi);                             /* push esi */
            ii(0x1007_1f3c, 1); pushd(edi);                             /* push edi */
            ii(0x1007_1f3d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_1f3e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_1f40, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1007_1f46, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_1f49, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_1f4c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_1f4f, 2); jmpd(0x1007_1f7a, 0x29); goto l_0x1007_1f7a; /* jmp 0x10071f7a */
        l_0x1007_1f51:
            ii(0x1007_1f51, 7); mov(memd_a32[ss, ebp - 0xc], 0x1);      /* mov dword [ebp-0xc], 0x1 */
            ii(0x1007_1f58, 5); jmpd(0x1007_1fe9, 0x8c); goto l_0x1007_1fe9; /* jmp 0x10071fe9 */
        l_0x1007_1f5d:
            ii(0x1007_1f5d, 7); mov(memd_a32[ss, ebp - 0xc], 0xffff_ffff); /* mov dword [ebp-0xc], 0xffffffff */
            ii(0x1007_1f64, 5); jmpd(0x1007_1fe9, 0x80); goto l_0x1007_1fe9; /* jmp 0x10071fe9 */
        l_0x1007_1f69:
            ii(0x1007_1f69, 7); mov(memd_a32[ss, ebp - 0xc], 0xffff_fffa); /* mov dword [ebp-0xc], 0xfffffffa */
            ii(0x1007_1f70, 5); jmpd(0x1007_1fe9, 0x74); goto l_0x1007_1fe9; /* jmp 0x10071fe9 */
        l_0x1007_1f75:
            ii(0x1007_1f75, 5); jmpd(0x1007_1fe2, 0x68); goto l_0x1007_1fe2; /* jmp 0x10071fe2 */
        l_0x1007_1f7a:
            ii(0x1007_1f7a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_1f7d, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1007_1f80, 5); cmp(memw_a32[ss, ebp - 0x10], 0x17);    /* cmp word [ebp-0x10], 0x17 */
            ii(0x1007_1f85, 2); if(jbd(0x1007_1fbe, 0x37)) goto l_0x1007_1fbe; /* jb 0x10071fbe */
            ii(0x1007_1f87, 5); cmp(memw_a32[ss, ebp - 0x10], 0x19);    /* cmp word [ebp-0x10], 0x19 */
            ii(0x1007_1f8c, 2); if(jbed(0x1007_1f51, -0x3d)) goto l_0x1007_1f51; /* jbe 0x10071f51 */
            ii(0x1007_1f8e, 5); cmp(memw_a32[ss, ebp - 0x10], 0x1d);    /* cmp word [ebp-0x10], 0x1d */
            ii(0x1007_1f93, 2); if(jbd(0x1007_1fb5, 0x20)) goto l_0x1007_1fb5; /* jb 0x10071fb5 */
            ii(0x1007_1f95, 5); cmp(memw_a32[ss, ebp - 0x10], 0x1e);    /* cmp word [ebp-0x10], 0x1e */
            ii(0x1007_1f9a, 2); if(jbed(0x1007_1f51, -0x4b)) goto l_0x1007_1f51; /* jbe 0x10071f51 */
            ii(0x1007_1f9c, 5); cmp(memw_a32[ss, ebp - 0x10], 0x20);    /* cmp word [ebp-0x10], 0x20 */
            ii(0x1007_1fa1, 2); if(jbd(0x1007_1fb3, 0x10)) goto l_0x1007_1fb3; /* jb 0x10071fb3 */
            ii(0x1007_1fa3, 5); cmp(memw_a32[ss, ebp - 0x10], 0x20);    /* cmp word [ebp-0x10], 0x20 */
            ii(0x1007_1fa8, 2); if(jbed(0x1007_1f51, -0x59)) goto l_0x1007_1f51; /* jbe 0x10071f51 */
            ii(0x1007_1faa, 5); cmp(memw_a32[ss, ebp - 0x10], 0x28);    /* cmp word [ebp-0x10], 0x28 */
            ii(0x1007_1faf, 2); if(jzd(0x1007_1f51, -0x60)) goto l_0x1007_1f51; /* jz 0x10071f51 */
            ii(0x1007_1fb1, 2); jmpd(0x1007_1f75, -0x3e); goto l_0x1007_1f75; /* jmp 0x10071f75 */
        l_0x1007_1fb3:
            ii(0x1007_1fb3, 2); jmpd(0x1007_1f75, -0x40); goto l_0x1007_1f75; /* jmp 0x10071f75 */
        l_0x1007_1fb5:
            ii(0x1007_1fb5, 5); cmp(memw_a32[ss, ebp - 0x10], 0x1b);    /* cmp word [ebp-0x10], 0x1b */
            ii(0x1007_1fba, 2); if(jzd(0x1007_1f51, -0x6b)) goto l_0x1007_1f51; /* jz 0x10071f51 */
            ii(0x1007_1fbc, 2); jmpd(0x1007_1f75, -0x49); goto l_0x1007_1f75; /* jmp 0x10071f75 */
        l_0x1007_1fbe:
            ii(0x1007_1fbe, 5); cmp(memw_a32[ss, ebp - 0x10], 0x1);     /* cmp word [ebp-0x10], 0x1 */
            ii(0x1007_1fc3, 2); if(jbd(0x1007_1fd5, 0x10)) goto l_0x1007_1fd5; /* jb 0x10071fd5 */
            ii(0x1007_1fc5, 5); cmp(memw_a32[ss, ebp - 0x10], 0x1);     /* cmp word [ebp-0x10], 0x1 */
            ii(0x1007_1fca, 2); if(jbed(0x1007_1f69, -0x63)) goto l_0x1007_1f69; /* jbe 0x10071f69 */
            ii(0x1007_1fcc, 5); cmp(memw_a32[ss, ebp - 0x10], 0x2);     /* cmp word [ebp-0x10], 0x2 */
            ii(0x1007_1fd1, 2); if(jzd(0x1007_1f5d, -0x76)) goto l_0x1007_1f5d; /* jz 0x10071f5d */
            ii(0x1007_1fd3, 2); jmpd(0x1007_1f75, -0x60); goto l_0x1007_1f75; /* jmp 0x10071f75 */
        l_0x1007_1fd5:
            ii(0x1007_1fd5, 5); cmp(memw_a32[ss, ebp - 0x10], 0);       /* cmp word [ebp-0x10], 0x0 */
            ii(0x1007_1fda, 6); if(jzd(0x1007_1f51, -0x8f)) goto l_0x1007_1f51; /* jz 0x10071f51 */
            ii(0x1007_1fe0, 2); jmpd(0x1007_1f75, -0x6d); goto l_0x1007_1f75; /* jmp 0x10071f75 */
        l_0x1007_1fe2:
            ii(0x1007_1fe2, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
        l_0x1007_1fe9:
            ii(0x1007_1fe9, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_1fec, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_1fee, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_1fef, 1); popd(edi);                              /* pop edi */
            ii(0x1007_1ff0, 1); popd(esi);                              /* pop esi */
            ii(0x1007_1ff1, 1); popd(edx);                              /* pop edx */
            ii(0x1007_1ff2, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_1ff3, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_1ff4, 1); retd(); return;                         /* ret */
        }
    }
}