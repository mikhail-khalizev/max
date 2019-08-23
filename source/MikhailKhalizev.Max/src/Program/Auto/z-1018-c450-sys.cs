using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_c450-e3071d55")]
        public void /* sys */ Method_1018_c450()
        {
            ii(0x1018_c450, 1); pushd(ebp);                             /* push ebp */
            ii(0x1018_c451, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1018_c453, 1); pushd(ebx);                             /* push ebx */
            ii(0x1018_c454, 1); pushd(ecx);                             /* push ecx */
            ii(0x1018_c455, 1); pushd(edx);                             /* push edx */
            ii(0x1018_c456, 3); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1018_c459, 7); cmp(memd_a32[ds, 0x1020_b700], 0);      /* cmp dword [0x1020b700], 0x0 */
            ii(0x1018_c460, 2); if(jzd(0x1018_c469, 0x7)) goto l_0x1018_c469; /* jz 0x1018c469 */
            ii(0x1018_c462, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1018_c467, 2); jmpd(0x1018_c49b, 0x32); goto l_0x1018_c49b; /* jmp 0x1018c49b */
        l_0x1018_c469:
            ii(0x1018_c469, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1018_c46c, 5); mov(edx, 0x1020_b708);                  /* mov edx, 0x1020b708 */
            ii(0x1018_c471, 5); mov(ebx, 0x1020_b704);                  /* mov ebx, 0x1020b704 */
            ii(0x1018_c476, 1); pushd(eax);                             /* push eax */
            ii(0x1018_c477, 3); lea(ecx, ebp - 0x10);                   /* lea ecx, [ebp-0x10] */
            ii(0x1018_c47a, 5); mov(eax, 0x80);                         /* mov eax, 0x80 */
            ii(0x1018_c47f, 5); calld(/* sys */ 0x1019_43f0, 0x7f6c);   /* call 0x101943f0 */
            ii(0x1018_c484, 5); mov(memd_a32[ds, 0x1020_b700], eax);    /* mov [0x1020b700], eax */
            ii(0x1018_c489, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_c48b, 3); setnz(al);                              /* setnz al */
            ii(0x1018_c48e, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1018_c493, 3); setnz(al);                              /* setnz al */
            ii(0x1018_c496, 5); and(eax, 0xff);                         /* and eax, 0xff */
        l_0x1018_c49b:
            ii(0x1018_c49b, 3); lea(esp, ebp - 0xc);                    /* lea esp, [ebp-0xc] */
            ii(0x1018_c49e, 1); popd(edx);                              /* pop edx */
            ii(0x1018_c49f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1018_c4a0, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_c4a1, 1); popd(ebp);                              /* pop ebp */
            ii(0x1018_c4a2, 1); retd();                                 /* ret */
        }
    }
}
