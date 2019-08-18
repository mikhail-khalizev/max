using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_7861-8cd4656b")]
        public void Method_100a_7861()
        {
            ii(0x100a_7861, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x100a_7866, 5); calld(Definitions.sys_check_available_stack_size, 0xb_e4e7); /* call 0x10165d52 */
            ii(0x100a_786b, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_786c, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_786d, 1); pushd(esi);                             /* push esi */
            ii(0x100a_786e, 1); pushd(edi);                             /* push edi */
            ii(0x100a_786f, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_7870, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_7872, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100a_7878, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_787b, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_787e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_7881, 4); cmp(memd_a32[ds, eax + 0x52], 0x40);    /* cmp dword [eax+0x52], 0x40 */
            ii(0x100a_7885, 2); if(jnzd(0x100a_7896, 0xf)) goto l_0x100a_7896; /* jnz 0x100a7896 */
            ii(0x100a_7887, 5); mov(edx, StringDefinitions.ClearAirZones); /* mov edx, 0x101a0c5b */
            ii(0x100a_788c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_788f, 5); calld(Definitions.sys_strcpy, 0xb_e63b); /* call 0x10165ecf */
            ii(0x100a_7894, 2); jmpd(0x100a_78a3, 0xd); goto l_0x100a_78a3; /* jmp 0x100a78a3 */
        l_0x100a_7896:
            ii(0x100a_7896, 5); mov(edx, StringDefinitions.ClearLandSeaZones); /* mov edx, 0x101a0c6d */
            ii(0x100a_789b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_789e, 5); calld(Definitions.sys_strcpy, 0xb_e62c); /* call 0x10165ecf */
        l_0x100a_78a3:
            ii(0x100a_78a3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_78a6, 3); mov(al, memb_a32[ds, eax + 0x13]);      /* mov al, [eax+0x13] */
            ii(0x100a_78a9, 3); mov(memb_a32[ss, ebp - 0x10], al);      /* mov [ebp-0x10], al */
            ii(0x100a_78ac, 5); jmpd(0x100a_7940, 0x8f); goto l_0x100a_7940; /* jmp 0x100a7940 */
        //    ii(0x100a_78b1, 5); mov(edx, StringDefinitions.Waiting);    /* mov edx, 0x101a0c86 */
        //    ii(0x100a_78b6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
        //    ii(0x100a_78b9, 5); calld(Definitions.sys_strcat, 0xb_e673); /* call 0x10165f31 */
        //    ii(0x100a_78be, 5); jmpd(0x100a_795b, 0x98); goto l_0x100a_795b; /* jmp 0x100a795b */
        //    ii(0x100a_78c3, 5); mov(edx, StringDefinitions.ExaminingZones); /* mov edx, 0x101a0c8e */
        //    ii(0x100a_78c8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
        //    ii(0x100a_78cb, 5); calld(Definitions.sys_strcat, 0xb_e661); /* call 0x10165f31 */
        //    ii(0x100a_78d0, 5); jmpd(0x100a_795b, 0x86); goto l_0x100a_795b; /* jmp 0x100a795b */
        //    ii(0x100a_78d5, 5); mov(edx, StringDefinitions.SearchingMap); /* mov edx, 0x101a0c9e */
        //    ii(0x100a_78da, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
        //    ii(0x100a_78dd, 5); calld(Definitions.sys_strcat, 0xb_e64f); /* call 0x10165f31 */
        //    ii(0x100a_78e2, 5); jmpd(0x100a_795b, 0x74); goto l_0x100a_795b; /* jmp 0x100a795b */
        //    ii(0x100a_78e7, 5); mov(edx, StringDefinitions.WaitingForPath); /* mov edx, 0x101a0cac */
        //    ii(0x100a_78ec, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
        //    ii(0x100a_78ef, 5); calld(Definitions.sys_strcat, 0xb_e63d); /* call 0x10165f31 */
        //    ii(0x100a_78f4, 2); jmpd(0x100a_795b, 0x65); goto l_0x100a_795b; /* jmp 0x100a795b */
        //    ii(0x100a_78f6, 5); mov(edx, StringDefinitions.Moving2);    /* mov edx, 0x101a0cbd */
        //    ii(0x100a_78fb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
        //    ii(0x100a_78fe, 5); calld(Definitions.sys_strcat, 0xb_e62e); /* call 0x10165f31 */
        //    ii(0x100a_7903, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
        //    ii(0x100a_7906, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
        //    ii(0x100a_7909, 5); calld(0x1007_6574, -0x3_139a);          /* call 0x10076574 */
        //    ii(0x100a_790e, 3); mov(edx, memd_a32[ds, eax + 0x6]);      /* mov edx, [eax+0x6] */
        //    ii(0x100a_7911, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
        //    ii(0x100a_7914, 3); imul(edx, edx, 0x33);                   /* imul edx, edx, 0x33 */
        //    ii(0x100a_7917, 6); mov(edx, memd_a32[ds, edx + 0x101c_81d7]); /* mov edx, [edx+0x101c81d7] */
        //    ii(0x100a_791d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
        //    ii(0x100a_7920, 5); calld(Definitions.sys_strcat, 0xb_e60c); /* call 0x10165f31 */
        //    ii(0x100a_7925, 2); jmpd(0x100a_795b, 0x34); goto l_0x100a_795b; /* jmp 0x100a795b */
        l_0x100a_7927:
            ii(0x100a_7927, 2); jmpd(0x100a_795b, 0x32); goto l_0x100a_795b; /* jmp 0x100a795b */
        //    ii(0x100a_7929, 3); lea(eax, eax + 0);                      /* lea eax, [eax] */
        //    ii(0x100a_792c, 2); mov(cl, 0x78);                          /* mov cl, 0x78 */
        //    ii(0x100a_792e, 2); or(dl, memb_a32[ds, eax]);              /* or dl, [eax] */
        //    ii(0x100a_7930, 1); retd(); return;                         /* ret */
        //  ii(0x100a_7931, 15); Недостижимый (и не декодированный) код.
        l_0x100a_7940:
            ii(0x100a_7940, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x100a_7943, 3); mov(memb_a32[ss, ebp - 0x14], al);      /* mov [ebp-0x14], al */
            ii(0x100a_7946, 4); cmp(memb_a32[ss, ebp - 0x14], 0x4);     /* cmp byte [ebp-0x14], 0x4 */
            ii(0x100a_794a, 2); if(jad(0x100a_7927, -0x25)) goto l_0x100a_7927; /* ja 0x100a7927 */
            ii(0x100a_794c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_794e, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x100a_7951, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100a_7954, 7); if(jmpd_abs(memd_a32[cs, eax + 0x100a_792c])) return; /* jmp dword [cs:eax+0x100a792c] */
        l_0x100a_795b:
            ii(0x100a_795b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_795e, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_7961, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_7964, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_7966, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_7967, 1); popd(edi);                              /* pop edi */
            ii(0x100a_7968, 1); popd(esi);                              /* pop esi */
            ii(0x100a_7969, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_796a, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_796b, 1); retd(); return;                         /* ret */
        }
    }
}
