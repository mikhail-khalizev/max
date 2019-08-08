using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2cebe5e9-bf5a-47b4-bf22-a6970e1b7f6e")]
        public void Method_1014_847b()
        {
            ii(0x1014_847b, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1014_8480, 5); calld(Definitions.sys_check_available_stack_size, 0x1_d8cd); /* call 0x10165d52 */
            ii(0x1014_8485, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_8486, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_8487, 1); pushd(edx);                             /* push edx */
            ii(0x1014_8488, 1); pushd(esi);                             /* push esi */
            ii(0x1014_8489, 1); pushd(edi);                             /* push edi */
            ii(0x1014_848a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_848b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_848d, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1014_8493, 7); cmp(memd_a32[ds, 0x101c_8138], 0);      /* cmp dword [0x101c8138], 0x0 */
            ii(0x1014_849a, 2); if(jzd(0x1014_84a5, 0x9)) goto l_0x1014_84a5; /* jz 0x101484a5 */
            ii(0x1014_849c, 7); mov(memd_a32[ss, ebp - 0x4], 0xffff_ffff); /* mov dword [ebp-0x4], 0xffffffff */
            ii(0x1014_84a3, 2); jmpd(0x1014_84fb, 0x56); goto l_0x1014_84fb; /* jmp 0x101484fb */
        l_0x1014_84a5:
            ii(0x1014_84a5, 5); calld(0x1014_837e, -0x12c);             /* call 0x1014837e */
            ii(0x1014_84aa, 5); mov(eax, 0x8);                          /* mov eax, 0x8 */
            ii(0x1014_84af, 5); calld(/* sys */ 0x1017_92be, 0x3_0e0a); /* call 0x101792be */
            ii(0x1014_84b4, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1014_84b6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_84b8, 7); mov(memw_a32[ds, 0x101c_8128], bx);     /* mov [0x101c8128], bx */
            ii(0x1014_84bf, 6); mov(memd_a32[ds, 0x101c_8124], edx);    /* mov [0x101c8124], edx */
            ii(0x1014_84c5, 2); mov(eax, cs);                           /* mov eax, cs */
            ii(0x1014_84c7, 5); mov(edx, 0x1014_81d4);                  /* mov edx, 0x101481d4 */
            ii(0x1014_84cc, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1014_84ce, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1014_84d0, 5); mov(edx, 0x8);                          /* mov edx, 0x8 */
            ii(0x1014_84d5, 2); mov(ecx, ebx);                          /* mov ecx, ebx */
            ii(0x1014_84d7, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1014_84d9, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1014_84db, 5); calld(/* sys */ 0x1017_92f0, 0x3_0e10); /* call 0x101792f0 */
            ii(0x1014_84e0, 5); mov(eax, 0x4000);                       /* mov eax, 0x4000 */
            ii(0x1014_84e5, 5); calld(0x1014_8415, -0xd5);              /* call 0x10148415 */
            ii(0x1014_84ea, 10); mov(memd_a32[ds, 0x101c_8138], 0x1);   /* mov dword [0x101c8138], 0x1 */
            ii(0x1014_84f4, 7); mov(memd_a32[ss, ebp - 0x4], 0);        /* mov dword [ebp-0x4], 0x0 */
        l_0x1014_84fb:
            ii(0x1014_84fb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_84fe, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_8500, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_8501, 1); popd(edi);                              /* pop edi */
            ii(0x1014_8502, 1); popd(esi);                              /* pop esi */
            ii(0x1014_8503, 1); popd(edx);                              /* pop edx */
            ii(0x1014_8504, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_8505, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_8506, 1); retd(); return;                         /* ret */
        }
    }
}
