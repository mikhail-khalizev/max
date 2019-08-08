using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e7bce949-9c70-485a-ad78-2e2a4b2ebbd6")]
        public void Method_100f_1370()
        {
            ii(0x100f_1370, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x100f_1375, 5); calld(Definitions.sys_check_available_stack_size, 0x7_49d8); /* call 0x10165d52 */
            ii(0x100f_137a, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_137b, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_137c, 1); pushd(edx);                             /* push edx */
            ii(0x100f_137d, 1); pushd(esi);                             /* push esi */
            ii(0x100f_137e, 1); pushd(edi);                             /* push edi */
            ii(0x100f_137f, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_1380, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_1382, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100f_1388, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100f_138b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_138e, 4); cmp(memd_a32[ds, eax + 0x10], 0);       /* cmp dword [eax+0x10], 0x0 */
            ii(0x100f_1392, 2); if(jzd(0x100f_13be, 0x2a)) goto l_0x100f_13be; /* jz 0x100f13be */
            ii(0x100f_1394, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_1397, 3); mov(eax, memd_a32[ds, eax + 0x10]);     /* mov eax, [eax+0x10] */
            ii(0x100f_139a, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100f_139d, 4); cmp(memd_a32[ss, ebp - 0xc], 0);        /* cmp dword [ebp-0xc], 0x0 */
            ii(0x100f_13a1, 2); if(jzd(0x100f_13b7, 0x14)) goto l_0x100f_13b7; /* jz 0x100f13b7 */
            ii(0x100f_13a3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_13a5, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100f_13a8, 5); calld(Definitions.my_dtor_d2, -0x2_2e75); /* call 0x100ce538 */
            ii(0x100f_13ad, 5); calld(Definitions.sys_delete, 0x7_4bb2); /* call 0x10165f64 */
            ii(0x100f_13b2, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100f_13b5, 2); jmpd(0x100f_13be, 0x7); goto l_0x100f_13be; /* jmp 0x100f13be */
        l_0x100f_13b7:
            ii(0x100f_13b7, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
        l_0x100f_13be:
            ii(0x100f_13be, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_13c1, 7); mov(memd_a32[ds, eax + 0x10], 0);       /* mov dword [eax+0x10], 0x0 */
            ii(0x100f_13c8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_13cb, 4); cmp(memd_a32[ds, eax + 0x14], 0);       /* cmp dword [eax+0x14], 0x0 */
            ii(0x100f_13cf, 2); if(jzd(0x100f_13fb, 0x2a)) goto l_0x100f_13fb; /* jz 0x100f13fb */
            ii(0x100f_13d1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_13d4, 3); mov(eax, memd_a32[ds, eax + 0x14]);     /* mov eax, [eax+0x14] */
            ii(0x100f_13d7, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100f_13da, 4); cmp(memd_a32[ss, ebp - 0x14], 0);       /* cmp dword [ebp-0x14], 0x0 */
            ii(0x100f_13de, 2); if(jzd(0x100f_13f4, 0x14)) goto l_0x100f_13f4; /* jz 0x100f13f4 */
            ii(0x100f_13e0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_13e2, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100f_13e5, 5); calld(Definitions.my_dtor_d2, -0x2_2eb2); /* call 0x100ce538 */
            ii(0x100f_13ea, 5); calld(Definitions.sys_delete, 0x7_4b75); /* call 0x10165f64 */
            ii(0x100f_13ef, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100f_13f2, 2); jmpd(0x100f_13fb, 0x7); goto l_0x100f_13fb; /* jmp 0x100f13fb */
        l_0x100f_13f4:
            ii(0x100f_13f4, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
        l_0x100f_13fb:
            ii(0x100f_13fb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_13fe, 7); mov(memd_a32[ds, eax + 0x14], 0);       /* mov dword [eax+0x14], 0x0 */
            ii(0x100f_1405, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_1407, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_1408, 1); popd(edi);                              /* pop edi */
            ii(0x100f_1409, 1); popd(esi);                              /* pop esi */
            ii(0x100f_140a, 1); popd(edx);                              /* pop edx */
            ii(0x100f_140b, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_140c, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_140d, 1); retd(); return;                         /* ret */
        }
    }
}
