using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_f2cf-91df1dea")]
        public void Method_1010_f2cf()
        {
            ii(0x1010_f2cf, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x1010_f2d4, 5); calld(Definitions.sys_check_available_stack_size, 0x5_6a79); /* call 0x10165d52 */
            ii(0x1010_f2d9, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_f2da, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_f2db, 1); pushd(edx);                             /* push edx */
            ii(0x1010_f2dc, 1); pushd(esi);                             /* push esi */
            ii(0x1010_f2dd, 1); pushd(edi);                             /* push edi */
            ii(0x1010_f2de, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_f2df, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_f2e1, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1010_f2e7, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_f2ea, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_f2ed, 4); cmp(memd_a32[ds, eax + 0x15], 0);       /* cmp dword [eax+0x15], 0x0 */
            ii(0x1010_f2f1, 2); if(jzd(0x1010_f31d, 0x2a)) goto l_0x1010_f31d; /* jz 0x1010f31d */
            ii(0x1010_f2f3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_f2f6, 3); mov(eax, memd_a32[ds, eax + 0x15]);     /* mov eax, [eax+0x15] */
            ii(0x1010_f2f9, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1010_f2fc, 4); cmp(memd_a32[ss, ebp - 0xc], 0);        /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1010_f300, 2); if(jzd(0x1010_f316, 0x14)) goto l_0x1010_f316; /* jz 0x1010f316 */
            ii(0x1010_f302, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_f304, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_f307, 5); calld(Definitions.my_dtor_d6, -0x2_4235); /* call 0x100eb0d7 */
            ii(0x1010_f30c, 5); calld(Definitions.sys_delete, 0x5_6c53); /* call 0x10165f64 */
            ii(0x1010_f311, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1010_f314, 2); jmpd(0x1010_f31d, 0x7); goto l_0x1010_f31d; /* jmp 0x1010f31d */
        l_0x1010_f316:
            ii(0x1010_f316, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
        l_0x1010_f31d:
            ii(0x1010_f31d, 7); mov(memd_a32[ss, ebp - 0x8], 0xd);      /* mov dword [ebp-0x8], 0xd */
        l_0x1010_f324:
            ii(0x1010_f324, 3); dec(memd_a32[ss, ebp - 0x8]);           /* dec dword [ebp-0x8] */
            ii(0x1010_f327, 5); cmp(memw_a32[ss, ebp - 0x8], -0x1 /* 0xff */); /* cmp word [ebp-0x8], 0xffff */
            ii(0x1010_f32c, 2); if(jzd(0x1010_f371, 0x43)) goto l_0x1010_f371; /* jz 0x1010f371 */
            ii(0x1010_f32e, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_f332, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_f335, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1010_f338, 4); cmp(memd_a32[ds, eax + 0x19], 0);       /* cmp dword [eax+0x19], 0x0 */
            ii(0x1010_f33c, 2); if(jzd(0x1010_f36f, 0x31)) goto l_0x1010_f36f; /* jz 0x1010f36f */
            ii(0x1010_f33e, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_f342, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_f345, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1010_f348, 3); mov(eax, memd_a32[ds, eax + 0x19]);     /* mov eax, [eax+0x19] */
            ii(0x1010_f34b, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1010_f34e, 4); cmp(memd_a32[ss, ebp - 0x14], 0);       /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1010_f352, 2); if(jzd(0x1010_f368, 0x14)) goto l_0x1010_f368; /* jz 0x1010f368 */
            ii(0x1010_f354, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_f356, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1010_f359, 5); calld(Definitions.my_dtor_d2, -0x4_0e26); /* call 0x100ce538 */
            ii(0x1010_f35e, 5); calld(Definitions.sys_delete, 0x5_6c01); /* call 0x10165f64 */
            ii(0x1010_f363, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1010_f366, 2); jmpd(0x1010_f36f, 0x7); goto l_0x1010_f36f; /* jmp 0x1010f36f */
        l_0x1010_f368:
            ii(0x1010_f368, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
        l_0x1010_f36f:
            ii(0x1010_f36f, 2); jmpd(0x1010_f324, -0x4d); goto l_0x1010_f324; /* jmp 0x1010f324 */
        l_0x1010_f371:
            ii(0x1010_f371, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_f374, 5); calld(0x1010_f23d, -0x13c);             /* call 0x1010f23d */
            ii(0x1010_f379, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_f37b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_f37c, 1); popd(edi);                              /* pop edi */
            ii(0x1010_f37d, 1); popd(esi);                              /* pop esi */
            ii(0x1010_f37e, 1); popd(edx);                              /* pop edx */
            ii(0x1010_f37f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_f380, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_f381, 1); retd();                                 /* ret */
        }
    }
}
