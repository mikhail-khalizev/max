using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("771c2b5c-9b3b-457a-a326-d392da24645f")]
        public void Method_100f_eeec()
        {
            ii(0x100f_eeec, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100f_eef1, 5); calld(Definitions.sys_check_available_stack_size, 0x6_6e5c); /* call 0x10165d52 */
            ii(0x100f_eef6, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_eef7, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_eef8, 1); pushd(edx);                             /* push edx */
            ii(0x100f_eef9, 1); pushd(esi);                             /* push esi */
            ii(0x100f_eefa, 1); pushd(edi);                             /* push edi */
            ii(0x100f_eefb, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_eefc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_eefe, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100f_ef04, 7); mov(memd_a32[ss, ebp - 0x4], 0);        /* mov dword [ebp-0x4], 0x0 */
            ii(0x100f_ef0b, 2); jmpd(0x100f_ef13, 0x6); goto l_0x100f_ef13; /* jmp 0x100fef13 */
        l_0x100f_ef0d:
            ii(0x100f_ef0d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_ef10, 3); inc(memd_a32[ss, ebp - 0x4]);           /* inc dword [ebp-0x4] */
        l_0x100f_ef13:
            ii(0x100f_ef13, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_ef17, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100f_ef1a, 2); if(jged(0x100f_ef77, 0x5b)) goto l_0x100f_ef77; /* jge 0x100fef77 */
            ii(0x100f_ef1c, 5); mov(ebx, 0x62);                         /* mov ebx, 0x62 */
            ii(0x100f_ef21, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_ef25, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_ef2b, 5); mov(edx, 0x101c_a468);                  /* mov edx, 0x101ca468 */
            ii(0x100f_ef30, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100f_ef32, 6); add(edx, 0x11f);                        /* add edx, 0x11f */
            ii(0x100f_ef38, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_ef3c, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_ef42, 5); mov(ecx, 0x101c_a468);                  /* mov ecx, 0x101ca468 */
            ii(0x100f_ef47, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x100f_ef49, 5); add(eax, 0x11d);                        /* add eax, 0x11d */
            ii(0x100f_ef4e, 5); calld(/* sys */ 0x1016_6177, 0x6_7224); /* call 0x10166177 */
            ii(0x100f_ef53, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_ef57, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_ef5d, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100f_ef61, 6); imul(edx, edx, 0x247);                  /* imul edx, edx, 0x247 */
            ii(0x100f_ef67, 7); mov(ax, memw_a32[ds, eax + 0x101c_a550]); /* mov ax, [eax+0x101ca550] */
            ii(0x100f_ef6e, 7); mov(memw_a32[ds, edx + 0x101c_a5e7], ax); /* mov [edx+0x101ca5e7], ax */
            ii(0x100f_ef75, 2); jmpd(0x100f_ef0d, -0x6a); goto l_0x100f_ef0d; /* jmp 0x100fef0d */
        l_0x100f_ef77:
            ii(0x100f_ef77, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_ef79, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_ef7a, 1); popd(edi);                              /* pop edi */
            ii(0x100f_ef7b, 1); popd(esi);                              /* pop esi */
            ii(0x100f_ef7c, 1); popd(edx);                              /* pop edx */
            ii(0x100f_ef7d, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_ef7e, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_ef7f, 1); retd(); return;                         /* ret */
        }
    }
}
